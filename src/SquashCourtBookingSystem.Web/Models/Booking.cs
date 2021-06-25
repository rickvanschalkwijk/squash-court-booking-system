using System;

namespace SquashCourtBookingSystem.Models
{
    public class Booking
    {
        public Guid Id { get; set; }

        public Guid CourtId { get; set; }

        public virtual Court Court { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}