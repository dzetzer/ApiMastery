using ApiMastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repositories
{
    public class GameRepository : Repository<Game>, IRepository<Game>
    {
        private DbContext db;

        public GameRepository(DataContext context) : base(context)
        {
            this.db = context;
        }

        public override Game GetById(int id)
        {
            return db.Set<Game>().Where(i => i.GameId == id).Include("Games").FirstOrDefault();
        }
    }
}
