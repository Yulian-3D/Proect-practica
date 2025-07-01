using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Proect.API.Extensions;
using Project.BLL.Services.Contracts;
using Project.DAL.Configuration;
using Project.DAL.DTOs.UserDTOs;
using Project.DAL.Entities;

namespace Proect.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly ITokenService _tokenService;
    private IOptions<JwtConfiguration> _jwtConfiguration;
    public AuthController(ITokenService tokenService, UserManager<User> userManager, SignInManager<User> signInManager, IOptions<JwtConfiguration> jwtConfiguration)
    {
        _tokenService = tokenService;
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtConfiguration = jwtConfiguration;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        var user = new User
        {
            UserName = registerDto.Email,
            Email = registerDto.Email,
            Name = registerDto.Name,
            Count = 0
        };

        var result = await _userManager.CreateAsync(user, registerDto.Password);

        var roleResult = await _userManager.AddToRoleAsync(user, "User");

        if (!roleResult.Succeeded)
            return BadRequest(roleResult.Errors);

        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var user = await _userManager.FindByNameAsync(loginDto.Username);

        if (user == null)
            return Unauthorized();

        var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

        if (!result.Succeeded)
            return Unauthorized();

        var token = await _tokenService.GenerateTokenAsync(user);

        HttpContext.AppendTokenToCookie(token, _jwtConfiguration);

        return Ok(new { Token = token });
    }

    [Authorize]
    [HttpGet("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userManager.Users.ToListAsync();
        return Ok(users);
    }

    [HttpPost("logout")]
    [Authorize]
    public IActionResult Logout()
    {
        Response.Cookies.Delete("AuthToken");
        return Ok();
    }
}
