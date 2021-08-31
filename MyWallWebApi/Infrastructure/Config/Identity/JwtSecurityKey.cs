using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MyWallWebApi.Infrastructure.Config.Identity
{
    public class JwtSecurityKey
    {
        public static SymmetricSecurityKey Create(string secret)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
        }
    }
}