using Hotel.Domain.Enums;

namespace Hotel.Application.Dtos.Room;

public class RoomUpdateDto
{
    public Guid Id { get; set; }
    public string RoomNumber { get; set; } = string.Empty;
    public RoomType RoomType { get; set; }
    public RoomStatus Status { get; set; }
    public decimal PricePerNight { get; set; }
    public int Capacity { get; set; }
}