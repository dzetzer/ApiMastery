import React, {Component} from 'react';

class Sidebar extends Component {
    constructor(props)
    {
        super(props)
        this.state = {
            sideBarData: props.sideBarData,
        }
    
    }
    
    selectItem() {
        console.log("clicked")
    }

    render()
    {
        const sideBarData = this.state.sideBarData;
        return (
            
            <section id="sidebar-list">
            {sideBarData
                .map((object, i) => {
                    return <span onClick={this.selectItem} className="sidebar-item" key={i}>{object.name}</span>
                })}
            </section>
        );
    }
}

export default Sidebar;