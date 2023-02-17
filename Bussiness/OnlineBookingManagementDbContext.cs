using Bussiness.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class OnlineBookingManagementDbContext : DbContext
    {

        public OnlineBookingManagementDbContext(DbContextOptions<OnlineBookingManagementDbContext> options) 
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<MovieShow> MovieShows { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ShowSeat> ShowSeats { get; set; }

    }
}
