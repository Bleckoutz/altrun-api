namespace AltRun.API.Models;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public int Level { get; set; } = 1;

    public int Coins { get; set; } = 0;

    public string Role { get; set; } = "User";
}