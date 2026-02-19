using Hotel.Domain.Enums;

namespace Hotel.Application.Dtos.Room;

public record RoomDto(
    Guid Id,
    string RoomNumber,
    RoomType RoomType,
    RoomStatus Status,
    decimal PricePerNight,
    int Capacity);