namespace AltRun.API.DTOs;

public class UserDto
{
    public int Id { get; set; }

    public string Username { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public int Level { get; set; }

    public int Coins { get; set; }
}