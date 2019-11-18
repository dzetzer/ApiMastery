import React, {Component} from 'react';
import Update from "./Update";

class Body extends Component {
    selectGame(e) {
        const gameId = e.target.value;
        const seriesId = this.props.bodyData.seriesId;
        this.props.selectGame(gameId,seriesId);

        console.log("return gameId "+ gameId+"return seriesId "+ seriesId)
    }
    //Post
    postRequest(location, requestBody){
        fetch(location,{
            method:"POST",
            body: JSON.stringify(requestBody),
            headers: {"Content-Type": "application/json"}
        })
        .then(response => response.json())
        .then(response => console.log(response))
        .then(this.props.apiRefresh)
    }
    postGame(){
        event.preventDefault();
        const name = this.refs.name.value;
        const seriesId = this.props.bodyData.seriesId;
        this.postRequest("http://localhost:52305/api/games",{
            name: name,
            seriesId: seriesId
        })
    }
    postComment = event => {
        event.preventDefault();
        const title = this.refs.title.value;
        const body = this.refs.body.value;
        const gameId = this.props.bodyData.gameId;
        this.postRequest("http://localhost:52305/api/comments",{
            title: title,
            body: body,
            gameId: gameId
        })
    }
    //Delete
    deleteRequest(location){
        fetch(location,{
            method: "DELETE",
            header: {"Content-Type": "application/json"}
        })
        .then(this.props.apiRefresh)
    }
    deleteGame(e){
        const gameId = e.target.value;
        this.deleteRequest("http://localhost:52305/api/games/" + gameId)
        console.log("delete gameId " + gameId);
    }
    deleteComment(e){
        const commentId = e.target.value;
        this.deleteRequest("http://localhost:52305/api/comments/" + commentId)
        console.log("delete commentId " + commentId);
    }
    //Update
    selectUpdate(e){
        const updateObjectId = e.target.value;
        this.props.selectUpdate(updateObjectId);
    }

    render()
    {
        const bodyObject = this.props.bodyData;

        let content;

        if(bodyObject == null)
        {
            content = <div>Select an Item</div>
        }
        //For Series
        else if (this.props.bodyType == 0)
        {
            content = (
                <div>
                    <section id="body-parent">
                        <h1 id="parent-name">{bodyObject.name}</h1>
                    </section>
                    <section id="body-add-game">
                        <form onSubmit={this.postGame.bind(this)}>
                            <input type="text" name="name" ref="name"/>
                            <input type="submit" name="submit"/>
                        </form>
                    </section>
                    <section id="body-child-list">
                        {bodyObject.games
                        .map((game, i) => {
                            let content = (
                                <div>
                                    <button onClick={this.selectGame.bind(this)} className="body-child-item" value={game.gameId}>{game.name}</button>
                                    <button onClick={this.deleteGame.bind(this)} value={game.gameId}>Delete</button>
                                    <button onClick={this.selectUpdate.bind(this)} value={game.gameId}>Edit</button>
                                </div>
                            )
                            if(game.gameId == this.props.updateObjectId)
                            {
                                content = (
                                    <div>
                                        <button onClick={this.selectGame.bind(this)} className="body-child-item" value={game.gameId}>{game.name}</button>
                                        <button onClick={this.deleteGame.bind(this)} value={game.gameId}>Delete</button>
                                        <button onClick={this.selectUpdate.bind(this)} value={game.gameId}>Edit</button>
                                        <Update updateObjectId={this.props.updateObjectId} updateObject={game} updateType={0} apiRefresh={this.props.apiRefresh}/>
                                    </div>
                                )
                            }
                            return (
                                <div key={i}>{content}</div>
                            );
                        })}
                    </section>
                </div>
            )
        }
        //For Games
        else
        {
            content = (
                <div>
                    <section id="body-parent">
                        <h1 id="parent-name">{bodyObject.name}</h1>
                    </section>
                    <section id="body-add-comment">
                        <form onSubmit={this.postComment.bind(this)}>
                            <input type="text" name="title" ref="title"/>
                            <input type="text" name="body" ref="body"/>
                            <input type="submit" name="submit"/>
                        </form>
                    </section>
                    <section id="body-child-list">
                        {bodyObject.comments
                        .map((comment, i) => {
                            let content = (
                                <div>
                                    <span className="body-child-item" >{comment.title}</span>
                                    <span className="body-child-item" >{comment.body}</span>
                                    <button onClick={this.deleteComment.bind(this)} value={comment.commentId}>Delete</button>
                                    <button onClick={this.selectUpdate.bind(this)} value={comment.commentId}>Edit</button>
                                </div>
                            )
                            if(comment.commentId == this.props.updateObjectId)
                            {
                                content = (
                                    <div>
                                        <span className="body-child-item" >{comment.title}</span>
                                        <span className="body-child-item" >{comment.body}</span>
                                        <button onClick={this.deleteComment.bind(this)} value={comment.commentId}>Delete</button>
                                        <button onClick={this.selectUpdate.bind(this)} value={comment.commentId}>Edit</button>
                                        <Update updateObjectId={this.props.updateObjectId} updateObject={comment} updateType={1} apiRefresh={this.props.apiRefresh}/>
                                    </div>
                                )
                            }
                            return (
                                <div key={i}>{content}</div>
                            );
                        })}
                    </section>
                </div>
            )
        }
        return (
        <div>{content}</div>
        ); 
    }
}

export default Body;