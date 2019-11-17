import React, {Component} from "react";
import apiActions from "../src/api/ApiActions"
import Body from "./components/Body";
import Sidebar from "./components/Sidebar";

export default class App extends Component {
  constructor(props) {
    super(props);
      this.selectItem = this.selectItem.bind(this);
      this.state = {
        sideBarData: [],
        sideBarType: 0,
        bodyData: null,
        bodyType: 0,
        fetched: false,
        loading: false  
      }
  }
  componentDidMount() {
    sidebarLoadSeries();
  };

  sidebarLoadSeries() {
    this.setState({
      loading: true 
  });
  fetch("http://localhost:52305/api/series")
  .then(res => res.json())
  .then(responce => {
    this.setState({
      sideBarData: responce,
      sideBarType: 0,
      loading: true,
      fetched: true
    });
  });
  }

  selectSeries(seriesId) {
  fetch("http://localhost:52305/api/series/" + seriesId)
  .then(res => res.json())
  .then(responce => {
    this.setState({
      bodyData: responce,
      bodyType: 0
    });
  });
  console.log(this.state.bodyData)
  };

  selectGame(gameId) {
  fetch("http://localhost:52305/api/games/" + gameId)
  .then(res => res.json())
  .then(responce => {
    this.setState({
      sideBarData: this.state.bodyData,
      bodyData: responce,
      bodyType: 1,
      sidebarData: 1
    });
  });
  console.log(this.state.bodyData)
  };

  render (){
    const { fetched, loading } = this.state;

    let content;

    if (fetched){
      content = (
        <div>
          <Sidebar sideBarData={this.state.sideBarData} selectSeries={this.selectSeries} selectGame={this.selectGame} sideBarType={this.state.sideBarType}/>
          <Body bodyData={this.state.bodyData} bodyType={this.state.bodyType} selectGame={this.selectGame}/>
        </div>
      )
    } else if (loading && !fetched) {
      content = <div>Loading....</div>;
    }  else {
      content = <div />;
    }
    return <div>{content}</div>;  
  }
};
