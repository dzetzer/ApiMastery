import React, {Component} from 'react';

class Sidebar extends Component {
    constructor(props)
    {
        super(props)
        this.state = {
            sideBarData: props.sideBarData,
        }
    
    }
    render()
    {
        const sideBarData = this.state.sideBarData;
        return (
            
            <section id="sidebar-list">
            {sideBarData
                .map(object => {
                    return <span class="sidebar-item">{object.name}</span>
                })}
            </section>
        );
    }
}

export default Sidebar;