import React, {Component} from 'react';

class Body extends Component {
    constructor(bodyObject)
    {
        this.bodyObject = bodyObject;
    }
    render()
    {
        return (
            <div>
                <section id="body-parent">
                    <h1 id="parent-name">${bodyObject.name}</h1>
                </section>
                <section id="body-child-list">
                    ${bodyObject.games
                    .map(game => {
                        return (
                            <span class="body-child-item">${game.name}</span>
                        );
                    })
                    .join("")}
                </section>
            </div>
        );
    }
}

export default Body;