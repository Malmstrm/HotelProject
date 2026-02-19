namespace Hotel.Application.Dtos.Booking;

public class BookingCreateDto
{
    public Guid GuestId { get; set; }
    public Guid RoomId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
}