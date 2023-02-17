using Bussiness.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Cinema : BaseEntity
    {
        public string CinemaName { get; set; }
        public int TotalCinemaHalls { get; set; }

        public List<CinemaHall> CinemaHalls { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
