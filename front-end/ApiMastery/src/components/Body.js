import React, {Component} from 'react';

class Body extends Component {
    constructor(props)
    {
        super(props);
        this.state = {
            bodyObject: props.bodyData
        }
    }
    render()
    {
        const bodyObject = this.state.bodyObject;

        let content;

        if(bodyObject == null)
        {
            content = <div>Select an Item</div>
        }
        else
        {
            content = (
                <div>
                    <section id="body-parent">
                        <h1 id="parent-name">{bodyObject.name}</h1>
                    </section>
                    <section id="body-child-list">
                        {bodyObject.games
                        .map(game => {
                            return (
                                <span class="body-child-item">{game.name}</span>
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