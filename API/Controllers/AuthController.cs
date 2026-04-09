using API.Auth;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.Email == "admin@orderflow.com" && request.Password == "123456")
        {
            var token = _tokenService.GenerateToken("1", request.Email);
            return Ok(new { token });
        }

        return Unauthorized("Email ou senha inválidos");
    }
}

public record LoginRequest(string Email, string Password);