import React, {Component} from 'react';
import React, {useState} from 'react';
import Navigation from "./Navigation";
import Body from "./Body";
import Sidebar from "./Sidebar";

const [sidebarData, setSidebarData] = useState(Navigation.navData());
const [bodyData, setBodyData] = useState();

function DisplayApp() {
    

    function selectSeries(selectedOption) 
    {
        setBodyData(selectedOption);
    };
    function selectGame(selectedOption)
    {
        setSidebarData(selectedOption.games);
        setBodyData(selectedOption);
    };

    render()
    {
        return (
            <div id="app">
                <div id="sidebar">
                    <Sidebar sidebarObjects={sidebarData}/>
                </div>
                <div id="body">
                    <Body bodyObject={bodyData}/>
                </div>
            </div>
        );
    }
}

export default DisplayApp;