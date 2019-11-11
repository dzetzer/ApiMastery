using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMastery.Models
{
    public class Series
    {
        public int SeriesId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public Series(int seriesId, string name)
        {
            SeriesId = seriesId;
            Name = name;
        }
        public Series()
        {

        }

    }
}
