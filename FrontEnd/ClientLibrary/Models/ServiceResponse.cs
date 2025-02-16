namespace ClientLibrary.Models
{
    public record ServiceResponse(bool Success = false, string Message = null!, string Token = null!, string RefreshToken = null!);
}