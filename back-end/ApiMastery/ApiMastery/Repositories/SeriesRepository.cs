using ApiMastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Repositories
{
    public class SeriesRepository : Repository<Series>, IRepository<Series>
    {
        private DbContext db;
        
        public SeriesRepository(DataContext context) : base(context)
        {
            this.db = context;
        }

        public override Series GetById(int id)
        {
            return db.Set<Series>().Where(i => i.SeriesId == id).Include("Games").FirstOrDefault();
        }
    }
}
