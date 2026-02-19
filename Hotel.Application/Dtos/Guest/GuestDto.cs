namespace Hotel.Application.Dtos.Guest;

public record GuestDto(
    Guid Id,
    string FirstName,
    string LastName,
    string FulllName,
    string Email,
    string PhoneNumber);