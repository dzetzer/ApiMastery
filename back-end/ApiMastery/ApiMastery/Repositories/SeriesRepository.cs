using ApiMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repositories
{
    public class SeriesRepository : Repository<Series>, IRepository<Series>
    {
        public SeriesRepository(DataContext context) : base(context)
        {

        }
    }
}
