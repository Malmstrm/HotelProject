using Hotel.Domain.Common;
using Hotel.Domain.Enums;

namespace Hotel.Domain.Entities;

public class Booking : BaseEntity
{
    public Guid GuestId { get; set; }
    public Guid RoomId { get; set; }
    
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    
    public decimal TotalPrice { get; set; }
    public BookingStatus Status { get; set; }

    public Guest Guest { get; set; } = null!;
    public Room Room { get; set; } = null!;
}