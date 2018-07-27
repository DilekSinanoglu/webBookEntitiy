using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webBookReservation2.Models
{
    public class ReservationContext:DbContext
    {
        public ReservationContext():base("Reservationdb")
        {
            System.Data.Entity.Database.SetInitializer<ReservationContext>(null);
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}