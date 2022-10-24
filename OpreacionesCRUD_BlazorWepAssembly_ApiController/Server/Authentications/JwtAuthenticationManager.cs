using Microsoft.IdentityModel.Tokens;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Authentications
{
    public class JwtAuthenticationManager
    {
        public const string JWT_SECURITY_KEY = "yPkCqn4kSWLtaJwXvN2jGzpQRyTZ3gdXkt7FeBJP";
        public const int JWT_TOKEN_VALITY_MINS = 20;

        private UserAccountServices _userAccountServices;   
        public JwtAuthenticationManager(UserAccountServices userAccount)
        {
            _userAccountServices = userAccount;
        }

        public UserSession? GenereteJwtToken(string userName, string password)
        {
            if(string.IsNullOrWhiteSpace(userName)||string.IsNullOrWhiteSpace(password))
                return null;

            /*validar las credenciasles del usuario*/
            var userAccount = _userAccountServices.GetUserAccountByUserName(userName);
            if (userAccount == null || userAccount.Password != password)
            {
                return null;

            }

            /*Generar el Token*/
            var TokenExpiryTimeStamp = DateTime.UtcNow.AddMinutes(JWT_TOKEN_VALITY_MINS);
            var TokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);
            var claimsIdentity = new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, userAccount.UserName),
                new Claim(ClaimTypes.Role, userAccount.Role)
            });
            var siningCredemtials = new SigningCredentials(
                new SymmetricSecurityKey(TokenKey),
                SecurityAlgorithms.HmacSha256Signature);
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Expires = TokenExpiryTimeStamp,
                SigningCredentials = siningCredemtials
            
            };
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(securityToken);

            //Retornar el objeto de usuario de sesion
            var _userSession = new UserSession
            {
                UserName = userAccount.UserName,
                Role = userAccount.Role,
                Token = token,
                ExpiresIn = (int)TokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds

            };

            return _userSession;

        }
    }   
}
