using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using Project.BLL.Services.Contracts;
using Project.DAL.Configuration;
using Project.DAL.Entities;

namespace Project.BLL.Services
{
    public class TokenService : ITokenService
    {
        private readonly JwtConfiguration _jwtConfiguration;
        private readonly UserManager<User> _userManager;
        public TokenService(IConfiguration configuration, UserManager<User> userManager, IOptions<JwtConfiguration> options)
        {
            _userManager = userManager;
            _jwtConfiguration = options.Value;
        }

        public async Task<string> GenerateTokenAsync(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfiguration.SecretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName!),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("userName", user.UserName!)
            };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim("UserRole", role));
            }

            var token = new JwtSecurityToken(
                issuer: _jwtConfiguration.Issuer,
                audience: _jwtConfiguration.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtConfiguration.AccessTokenLifetime),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
