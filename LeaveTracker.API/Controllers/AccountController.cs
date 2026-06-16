using LeaveTracker.Application.DTO.Account;
using LeaveTracker.Application.Extensions;
using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using LeaveTracker.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace LeaveTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController(LeaveTrackerSQLDBContext context, ITokenService tokenService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO)
    {
        if (await EmailAddressExists(registerDTO.EmailAddress))
        {
            return BadRequest("Email address is already in use.");
        }

        using var hmac = new HMACSHA512();

        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDTO.Password));

        var user = UserExtensions.ToUser(registerDTO, passwordHash, hmac.Key);

        context.Users.Add(user);

        await context.SaveChangesAsync();

        var userDTO = UserExtensions.ToUserDTO(user, tokenService);

        return Ok(userDTO);
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserDTO>> Login([FromBody] LoginDTO loginDTO)
    {
        var user = await context.Users.SingleOrDefaultAsync(user => user.EmailAddress.Equals(loginDTO.EmailAddress.ToLower()));

        if (user == null)
        {
            return Unauthorized("Invalid email.");
        }

        using var hmac = new HMACSHA512(user.PasswordSalt);

        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDTO.Password));

        for (int i = 0; i < computedHash.Length; i++)
        {
            if (computedHash[i] != user.PasswordHash[i])
            {
                return Unauthorized("Invalid password.");
            }
        }

        var userDTO = UserExtensions.ToUserDTO(user, tokenService);

        return Ok(userDTO);
    }

    private async Task<bool> EmailAddressExists(string emailAddress)
    {
        return await context.Users.AnyAsync(User => EF.Functions.Like(User.EmailAddress, emailAddress));
    }
}
