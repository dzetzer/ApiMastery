import React, {Component} from 'react';
import {useState} from 'react';
import apiActions from '../api/ApiActions'
import Body from "./Body";
import Sidebar from "./Sidebar";


function DisplayApp() {
    render()
    {
        return (
            <div id="app">
                <div id="sidebar">
                    {/* <Sidebar sidebarObjects={sidebarData}/> */}
                </div>
                <div id="body">
                    {/* <Body bodyObject={bodyData}/> */}
                </div>
            </div>
        );
    }
}

export default DisplayApp;