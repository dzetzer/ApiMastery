import React, {Component} from 'react';
import DisplayApp from "./DisplayApp"

class Sidebar extends Component {
    constructor(sideBarData)
    {
        this.sideBarData = sideBarData;
    }
    render()
    {
        return (
            <section id="sidebar-list">
            {sideBarData
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