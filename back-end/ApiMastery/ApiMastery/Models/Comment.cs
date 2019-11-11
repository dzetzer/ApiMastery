using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        public Comment (int commentId, string title, string body, int gameId)
        {
            CommentId = commentId;
            Title = title;
            Body = body;
            GameId = gameId;
        }
        public Comment()
        {

        }
    }
}
