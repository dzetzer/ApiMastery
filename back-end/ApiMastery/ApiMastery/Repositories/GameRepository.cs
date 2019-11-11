using ApiMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repositories
{
    public class GameRepository : Repository<Game>, IRepository<Game>
    {
        public GameRepository(DataContext context) : base(context)
        {

        }
    }
}
