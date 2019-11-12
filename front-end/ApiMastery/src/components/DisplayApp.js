import React, {Component} from 'react';
import Body from "./Body";
import Sidebar from "./Sidebar";

class DisplayApp extends Component {
    render()
    {
        return (
            <div>
                <Sidebar/>
                <Body/>
            </div>
        );
    }
}

export default AppMain;