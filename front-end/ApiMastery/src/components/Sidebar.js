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
                    <span class="sidebar-item">Test</span>
                </section>
            </div>
        );
    }
}

export default Sidebar;