using Bussiness.Entities.Common;
using Bussiness.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class Booking : BaseEntity
    {
        public int NumberOfSeats { get; set; }
        public DateTime TimeSpan { get; set; }
        public BookingStatus Status { get; set; }

        public List<ShowSeat> ShowSeats { get; set; }
        public int MovieShowId { get; set; }
        public MovieShow MovieShow { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
