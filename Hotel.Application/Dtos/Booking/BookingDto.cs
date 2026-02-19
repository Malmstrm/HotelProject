using Hotel.Domain.Enums;

namespace Hotel.Application.Dtos.Booking;

public record BookingDto(
    Guid Id,
    Guid GuestId,
    Guid RoomId,
    string GuestFullName,
    string RoomNumber,
    DateTime CheckInDate,
    DateTime CheckOutDate,
    decimal TotalPrice,
    BookingStatus Status);