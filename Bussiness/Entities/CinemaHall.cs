using Bussiness.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class CinemaHall : BaseEntity
    {
        public string CinemaName { get; set; }
        public int TotalSeats { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        //public List<ShowSeat> ShowSeats { get; set; }
        public List<MovieShow> MovieShows { get; set; }

    }   
}
