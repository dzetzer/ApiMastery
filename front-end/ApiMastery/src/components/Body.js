import React, {Component} from 'react';

class Body extends Component {
    selectGame(e) {
        const gameId = e.target.value;
        this.props.selectGame(gameId);
        console.log("return gameId "+ gameId)
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