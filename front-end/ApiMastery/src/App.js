import React, {Component} from "react";
import apiActions from "../src/api/ApiActions"
import Body from "./components/Body";
import Sidebar from "./components/Sidebar";

// const Sidebar = document.querySelector(".sidebar");
// const Body = document.querySelector(".body");


// function navData(stateProp)
// {
//   apiActions.getRequest("http://localhost:52305/api/series", series => {
//     stateProp = series;
//     console.log(series);
//   });
// }

// const seriesData = null;
// navData(seriesData);
// const [sidebarData, setSidebarData] = useState(navData());
// const [bodyData, setBodyData] = useState(null);


export default class App extends Component {
  constructor(props) {
    super(props);
      this.state = {
        sideBarData: [],
        fetched: false,
        loading: false  
      }
  }

  componentWillMount() {
        this.setState({
        loading: true 
    });


    fetch("http://localhost:52305/api/series")
    .then(res => res.json())
    .then(responce => {
      this.setState({
        sideBarData: responce,
        loading: true,
        fetched: true
      });
    });
  };

  render (){
    const { fetched, loading, sideBarData } = this.state;

    let content;

    if (fetched){
      content =  <Sidebar sideBarData={this.state.sideBarData}/>
    } else if (loading && !fetched) {
      content = <div>Loading....</div>;
    }  else {
      content = <div />;
    }
    return <div>{content}</div>;  
  }
};
