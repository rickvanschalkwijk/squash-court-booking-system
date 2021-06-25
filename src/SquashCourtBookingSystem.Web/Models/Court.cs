using System;
using System.Collections.Generic;

namespace SquashCourtBookingSystem.Models
{
    public class Court
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public decimal Price { get; set; }

        public bool Available { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
