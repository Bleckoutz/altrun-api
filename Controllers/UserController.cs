using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;

using AltRun.API.Data;
using AltRun.API.Models;
using AltRun.API.DTOs;
using AltRun.API.Auth;

namespace AltRun.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    private readonly TokenService _tokenService;

    public UserController(
        AppDbContext context,
        TokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }

    [Authorize]

    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = _context.Users.Select(user => new UserDto
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Level = user.Level,
            Coins = user.Coins
        });

        return Ok(users);
    }

    [HttpPost]
    public IActionResult CreateUser(CreateUserDto dto)
    {
        var user = new User
        {
            Username = dto.Username,

            Email = dto.Email,

            PasswordHash =
                BCrypt.Net.BCrypt.HashPassword(dto.Password)
        };

        _context.Users.Add(user);

        _context.SaveChanges();

        return Ok(new UserDto
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            Level = user.Level,
            Coins = user.Coins
        });
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        var user = _context.Users
            .FirstOrDefault(u => u.Email == dto.Email);

        if (user == null)
            return Unauthorized("Usuário não encontrado");

        var passwordValid =
            BCrypt.Net.BCrypt.Verify(
                dto.Password,
                user.PasswordHash
            );

        if (!passwordValid)
            return Unauthorized("Senha inválida");

        var token = _tokenService.CreateToken(user);

        return Ok(new
        {
            token
        });
    }
}