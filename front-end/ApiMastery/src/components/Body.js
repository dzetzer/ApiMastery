import React, {Component} from 'react';

class Body extends Component {
    selectGame(e) {
        const gameId = e.target.value;
        const seriesId = this.props.bodyData.seriesId;
        this.props.selectGame(gameId,seriesId);
        console.log("return gameId "+ gameId+"return seriesId "+ seriesId)
    }
    postRequest(location, requestBody){
        fetch(location,{
            method:"POST",
            body: JSON.stringify(requestBody),
            headers: {"Content-Type": "application/json"}
        })
        .then(response => response.json())
        .then(response => console.log(response))
    }
    postGame(){

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
                    <section id="body-child-list">
                        {bodyObject.games
                        .map((game, i) => {
                            return (
                                <button onClick={this.selectGame.bind(this)} className="body-child-item" key={i} value={game.gameId}>{game.name}</button>
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
                            return (
                                <span className="body-child-item" key={i}>{comment.title}</span>
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