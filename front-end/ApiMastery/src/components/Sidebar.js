import React, {Component} from 'react';

class Sidebar extends Component {
    selectSeries(e) {
        const seriesId = e.target.value;
        this.props.selectSeries(seriesId);
        console.log("return seriesId "+ seriesId)
    }
    selectGame(e) {
        const gameId = e.target.value;
        this.props.selectGame(gameId);
        console.log("return gameId "+ gameId)
    }

    render()
    {
        const sideBarData = this.props.sideBarData;

        let content;

        //For All Series
        if(this.props.sideBarType == 0)
        {
            content = (
                <section id="sidebar-list">
                {sideBarData
                    .map((object, i) => {
                        return <button onClick={this.selectSeries.bind(this)} className="sidebar-item" key={i} value={object.seriesId}>{object.name}</button>
                    })}
                </section>
            )
        }
        //For One Series
        else
        {
            content = (
                <section id="sidebar-list">
                <button>Return to Series</button>
                {sideBarData.games
                    .map((game, i) => {
                        return <button onClick={this.selectGame.bind(this)} className="sidebar-item" key={i} value={game.gameId}>{game.name}</button>
                    })}
                </section>
            )
        }
        return (
            <div>{content}</div>
        );
    }
}

export default Sidebar;