using Bussiness.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }

        public int CinemaId { get; set; }
        public List<Cinema> Cinemas { get; set; }
    }
}
