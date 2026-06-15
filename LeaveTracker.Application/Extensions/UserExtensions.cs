using LeaveTracker.Application.DTO.Account;
using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;

namespace LeaveTracker.Application.Extensions;

public static class UserExtensions
{
    public static UserDTO ToUserDTO(this User source, ITokenService tokenService)
    {
        var userDTO = new UserDTO
        {
            Id = source.Id.ToString(),
            DisplayName = source.DisplayName,
            EmailAddress = source.EmailAddress,
            Token = tokenService.CreateToken(source)
        };

        return userDTO;
    }

    public static User ToUser(this RegisterDTO registerDTO, byte[] passwordHash, byte[] passwordSalt)
    {
        var user = new User
        {
            DisplayName = registerDTO.DisplayName,
            EmailAddress = registerDTO.EmailAddress.ToLower(),
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt
        };

        return user;
    }
}
