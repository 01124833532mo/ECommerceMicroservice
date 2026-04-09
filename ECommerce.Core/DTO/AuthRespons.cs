namespace ECommerce.Core.DTO;

public record AuthRespons(
    Guid UserId,
    string? Email,
    string? PersonName,
    string? Gender,
    string? Token,
    bool Success
 );


