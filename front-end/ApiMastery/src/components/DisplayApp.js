import React, {Component} from 'react';
import Body from "./Body";
import Sidebar from "./Sidebar";



class DisplayApp extends Component {
    render()
    {
        return (
            <div id="app">
                <div id="sidebar">
                    <Sidebar sidebarObjects=""/>
                </div>
                <div id="body">
                    <Body bodyObject=""/>
                </div>
            </div>
        );
    }
}

export default DisplayApp;