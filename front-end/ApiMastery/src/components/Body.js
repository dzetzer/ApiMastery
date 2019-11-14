import React, {Component} from 'react';

class Body extends Component {
    constructor(bodyObject)
    {
        this.bodyObject = bodyObject;
    }
    render()
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
                <span class="body-child-item"></span>
            </section>
        );
        return (
            <div>
                ${parentSection}
                ${childrenSection}
            </div>
        );
    }
}

export default Body;