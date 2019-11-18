import React, {Component} from 'react';

class Update extends Component {
  constructor(props){
    super(props);
    if(this.props.updateType == 0)
    {
      this.state = {
        name: this.props.updateObject.name
      }
    }
    else
    {
      this.state = {
        title: this.props.updateObject.title,
        body: this.props.updateObject.body
      }
    }
    
  }
  handleNameChange(event){
    this.setState({
      name: event.target.value
    })
  }
  handleTitleChange(event){
    this.setState({
      title: event.target.value
    })
  }
  handleBodyChange(event){
    this.setState({
      body: event.target.value
    })
  }

  putRequest(location, requestBody){
    fetch(location,{
        method:"PUT",
        body: JSON.stringify(requestBody),
        headers:{"Content-Type": "application/json"}
    })
    .then(this.props.apiRefresh)
  }
  updateGame(){
      event.preventDefault();
      const name = this.refs.name.value;
      const seriesId = this.props.updateObject.seriesId;
      const gameId = this.props.updateObjectId;
      this.putRequest("http://localhost:52305/api/games/" + this.props.updateObjectId,{
          name: name,
          seriesId: seriesId,
          gameId: gameId
      })
      //this.props.updateObjectId = null;
  }
  updateComment(){
      event.preventDefault();
      const title = this.refs.title.value;
      const body = this.refs.body.value;
      const gameId = this.props.updateObject.gameId;
      const commentId = this.props.updateObjectId;
      this.putRequest("http://localhost:52305/api/comments/" + this.props.updateObjectId,{
          title: title,
          body: body,
          gameId: gameId,
          commentId: commentId
      })
      //this.props.updateObjectId = null;
  }
  render()
  {
    const updateObject = this.props.updateObject;

    let content;

    //Update Game
    if(this.props.updateType == 0)
    {
      content = (
      <form onSubmit={this.updateGame.bind(this)}>
        <p>New Name</p>
        <input type="text" ref="name" value={this.state.name}  onChange={this.handleNameChange.bind(this)}/>
        <input className="button" type="submit" name="submit"/>
      </form>
      )
    }
    //Update Comment
    else
    {
      content = (
      <form onSubmit={this.updateComment.bind(this)}>
        <p>New Title</p>
        <input type="text" ref="title" value={this.state.title} onChange={this.handleTitleChange.bind(this)}/>
        <p>New Body</p>
        <input type="text" ref="body" value={this.state.body}  onChange={this.handleBodyChange.bind(this)}/>
        <input className="button" type="submit" name="submit"/>
      </form>
      )
    }

    return (
      <div className="update-form">{content}</div>
      ); 
  }
}

export default Update;