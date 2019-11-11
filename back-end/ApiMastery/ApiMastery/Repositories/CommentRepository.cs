using ApiMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repositories
{
    public class CommentRepository : Repository<Comment>, IRepository<Comment>
    {
        public CommentRepository(DataContext context) : base(context)
        {

        }
    }
}
