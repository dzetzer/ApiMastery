import React from "react";
import Body from "./components/Body";
import Sidebar from "./components/Sidebar";

const Sidebar = document.querySelector(".sidebar");
const Body = document.querySelector(".body");


function navData()
{
  apiActions.getRequest("https://localhost:44386/api/series", series);
  return series;
}

const [sidebarData, setSidebarData] = useState(navData());
const [bodyData, setBodyData] = useState(null);


export default class App extends React.Component {
  constructor(){
    super();
      this.state = {
        sideBarData: navData(),
      }
  }
  render (){
    return (
              <>
                <Sidebar sideBarData={this.state.sideBarData}/>
              </>
    )
  }
};
