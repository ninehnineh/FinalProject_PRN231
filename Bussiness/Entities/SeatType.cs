using Bussiness.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class SeatType : BaseEntity
    {
        public int SeatNumber { get; set; }
        public string Type { get; set; }

        public int ShowSeatId { get; set; }
        public List<ShowSeat> ShowSeats { get; set; }
    }
}
