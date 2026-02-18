using Hotel.Domain.Common;
using Hotel.Domain.Enums;

namespace Hotel.Domain.Entities;

public class Room : BaseEntity
{
    public string RoomNumber { get; set; } = string.Empty;
    public RoomType RoomType { get; set; }
    public RoomStatus Status { get; set; }
    public decimal PricePerNight { get; set; }
    public int Capacity { get; set; }
    
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}