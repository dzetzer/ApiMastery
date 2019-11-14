import React, {Component} from 'react';

class Sidebar extends Component {
    constructor(sidebarObjects)
    {
        this.sidebarObjects = sidebarObjects;
    }
    render()
    {
        return (
            <div>
                <section id="sidebar-list">
                ${sidebarObjects
                    .map(object => {
                        return `
                            <span class="sidebar-item">${object.name}</span>
                        `;
                    })
                    .join("")}
                </section>
            </div>
        );
    }
}

export default Sidebar;