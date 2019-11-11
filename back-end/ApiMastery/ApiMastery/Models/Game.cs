using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }

        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public Game(int gameId, string name, int seriesId)
        {
            GameId = gameId;
            Name = name;
            SeriesId = seriesId;
        }
        public Game()
        {

        }
    }
}
