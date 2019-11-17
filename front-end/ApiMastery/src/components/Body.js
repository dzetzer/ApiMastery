import React, {Component} from 'react';

class Body extends Component {
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
                                <span className="body-child-item" key={i}>{game.name}</span>
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
                                <span className="body-child-item" key={i}>{game.name}</span>
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