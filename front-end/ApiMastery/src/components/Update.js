import React, {Component} from 'react';

class Update extends Component {
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
      putRequest("http://localhost:52305/api/games/" + gameId,{
          name: name,
          seriesId: seriesId
      })
      this.props.updateObjectId = null;
  }
  updateComment(){
      event.preventDefault();
      const title = this.refs.title.value;
      const body = this.refs.body.value;
      const gameId = this.props.updateObject.gameId;
      putRequest("http://localhost:52305/api/comments/" + commentId,{
          title: title,
          body: body,
          gameId: gameId
      })
      this.props.updateObjectId = null;
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
        <input type="text" ref="name" value={updateObject.name}/>
        <input type="submit" name="submit"/>
      </form>
      )
    }
    //Update Comment
    else
    {
      content = (
      <form onSubmit={this.updateComment.bind(this)}>
        <input type="text" ref="title" value={updateObject.title}/>
        <input type="text" ref="body" value={updateObject.body}/>
        <input type="submit" name="submit"/>
      </form>
      )
    }

    return (
      <div>{content}</div>
      ); 
  }
}

export default Update;