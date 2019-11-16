import React, {Component} from 'react';

class Sidebar extends Component {
    constructor(props)
    {
        super(props)
        this.state = {
            sideBarData: props.sideBarData,
        }
    
    }
    
    selectItem(e) {
        const seriesId = e.target.value;
        props.selectItem(seriesId);
        console.log(seriesId)
    }

    render()
    {
        const sideBarData = this.state.sideBarData;
        return (
            
            <section id="sidebar-list">
            {sideBarData
                .map((object, i) => {
                    return <button onClick={this.selectItem} className="sidebar-item" key={i} value={object.seriesId}>{object.name}</button>
                })}
            </section>
        );
    }
}

export default Sidebar;