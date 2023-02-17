using Bussiness.Entities.Common;
using Bussiness.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Entities
{
    public class ShowSeat : BaseEntity
    {
        public ShowSeatStatus Status { get; set; }
        public decimal Price { get; set; }

        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int SeatTypeId { get; set; }
        public SeatType SeatType { get; set; }
        //public int CinemaHallId { get; set; }
        //public CinemaHall CinemaHall { get; set; }
    }
}
