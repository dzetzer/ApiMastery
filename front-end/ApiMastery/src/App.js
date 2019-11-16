import React from "react";
import apiActions from "../src/api/ApiActions"
import Body from "./components/Body";
import Sidebar from "./components/Sidebar";

// const Sidebar = document.querySelector(".sidebar");
// const Body = document.querySelector(".body");


function navData(stateProp)
{
  apiActions.getRequest("http://localhost:52305/api/series", series => {
    stateProp = series;
    console.log(series);
  });
}

// const seriesData = null;
// navData(seriesData);
// const [sidebarData, setSidebarData] = useState(navData());
// const [bodyData, setBodyData] = useState(null);


export default class App extends React.Component {
  constructor(){
    super();
      this.state = {
        sideBarData: null,
      }
  }
  componentWillMount() {
      apiActions.getRequest("http://localhost:52305/api/series", series => {
        this.setState({sideBarData : series});
        console.log(series);
    });
  };
  render (){
    return (
              <>
                <Sidebar sideBarData={this.state.sideBarData}/>
              </>
    )
  }
};
