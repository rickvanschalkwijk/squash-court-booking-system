using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SquashCourtBookingSystem.Models
{
    public sealed class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
