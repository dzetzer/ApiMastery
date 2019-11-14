import React, {Component} from 'react';

class Sidebar extends Component {
    constructor(sidebarObjects)
    {
        this.sidebarObjects = sidebarObjects;
    }
    render()
    {
        return (
            <section id="sidebar-list">
            ${sidebarObjects
                .map(object => {
                    return `
                        <span class="sidebar-item">${object.name}</span>
                    `;
                })
                .join("")}
            </section>
        );
    }
}

export default Sidebar;