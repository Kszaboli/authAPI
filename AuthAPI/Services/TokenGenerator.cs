using AuthAPI.Models;
using AuthAPI.Services.IService;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthAPI.Services
{
    public class TokenGenerator : ITokenGenerator
    {
        private readonly JWTOption jWTOption;

        public TokenGenerator(IOptions<JWTOption> jwtOption)
        {
            this.jWTOption = jWTOption;
        }

        public string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();    
            var kex = Encoding.ASCII.GetBytes(jWTOption.Secret);
            var claimList = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,applicationUser.Id),
                new Claim(JwtRegisteredClaimNames.Name,applicationUser.UserName.ToString()),
                new Claim(JwtRegisteredClaimNames.Name,applicationUser.FullName.ToString()),
            };
            claimList.AddRange(roles.Select(role=>new Claim(ClaimTypes.Role,role)));

            var tokenDescription = new SecurityTokenDescriptor
            {
                Audience = jWTOption.Audience,
                Issuer = jWTOption.Issuer,
                Subject = new ClaimsIdentity(claimList),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(token);
        }
    }
}
