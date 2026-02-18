using Hotel.Domain.Common;

namespace Hotel.Domain.Entities;

public class Guest : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}