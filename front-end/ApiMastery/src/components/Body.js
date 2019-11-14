import React, {Component} from 'react';

class Body extends Component {
    constructor(bodyObject, modelId)
    {
        this.bodyObject = bodyObject;
    }
    render()
    {
        //series
        if(modelId = 0)
        {
            parentSection =
            (
                <section id="body-parent">
                    <h1 id="parent-name">${bodyObject.name}</h1>
                </section>
            );
            childrenSection = 
            (
                <section id="body-child-list">
                    ${bodyObject.games
                    .map(game => {
                        return `
                            <span class="body-child-item">${game.name}</span>
                        `;
                    })
                    .join("")}
                    
                </section>
            );
        }
        //game
        else
        {
            parentSection =
            (
                <section id="body-parent">
                    <h1 id="parent-name">${bodyObject.name}</h1>
                </section>
            );
            childrenSection = 
            (
                <section id="body-child-list">
                    ${bodyObject.comments
                    .map(comment => {
                        return `
                            <span class="body-child-item">${comment.title}</span>
                        `;
                    })
                    .join("")}
                </section>
            );
        }
        
        return (
            <div>
                ${parentSection}
                ${childrenSection}
            </div>
        );
    }
}

export default Body;