using Hotel.Domain.Enums;

namespace Hotel.Application.Dtos.Booking;

public class BookingUpdateDto
{
    public Guid Id { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public BookingStatus Status { get; set; }
}