import React, {Component} from 'react';
import DisplayApp from "./DisplayApp"

function optionSelect(optionSelected)
{
    DisplayApp.sidebarData = optionSelected;
};

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
                    return 
                    (
                        <span class="sidebar-item">${object.name}</span>
                    );
                })
                .join("")}
            </section>
        );
    }
}

export default Sidebar;