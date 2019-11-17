import React, {Component} from "react";
import Body from "./components/Body";
import Sidebar from "./components/Sidebar";

export default class App extends Component {
  constructor(props) {
    super(props);
      this.apiRefresh = this.apiRefresh.bind(this);
      this.selectSeriesBody = this.selectSeriesBody.bind(this);
      this.selectGameBody = this.selectGameBody.bind(this);
      this.selectGameSideBar = this.selectGameSideBar.bind(this);
      this.selectGame = this.selectGame.bind(this);
      this.sidebarLoadSeries = this.sidebarLoadSeries.bind(this);
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
    this.sidebarLoadSeries();
  };

  apiRefresh(){
    if(this.state.sideBarType == 0) sidebarLoadSeries() 
    else this.selectGameSideBar(this.state.sideBarData.seriesId);

    if(this.state.bodyType == 0) this.selectSeriesBody(this.state.bodyData.seriesId);
    else this.selectGameBody(this.state.bodyData.gameId);
  }

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

  selectSeriesBody(seriesId) {
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

  selectGameBody(gameId){
    fetch("http://localhost:52305/api/games/" + gameId)
    .then(res => res.json())
    .then(responce => {
      this.setState({
        bodyData: responce,
        bodyType: 1,
      });
    });
  }

  selectGameSideBar(seriesId){
    fetch("http://localhost:52305/api/series/" + seriesId)
  .then(res => res.json())
  .then(responce => {
    this.setState({
      sideBarData: responce,
      sideBarType: 1
    });
  });
  }

  selectGame(gameId, seriesId) {
    this.selectGameBody(gameId);
    this.selectGameSideBar(seriesId);
    console.log(this.state.bodyData)
  };

  render (){
    const { fetched, loading } = this.state;

    let content;

    if (fetched){
      content = (
        <div>
          <Sidebar sideBarData={this.state.sideBarData} sidebarLoadSeries={this.sidebarLoadSeries} selectSeriesBody={this.selectSeriesBody} selectGame={this.selectGame} sideBarType={this.state.sideBarType}/>
          <Body bodyData={this.state.bodyData} bodyType={this.state.bodyType} selectGame={this.selectGame} apiRefresh={this.apiRefresh}/>
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
