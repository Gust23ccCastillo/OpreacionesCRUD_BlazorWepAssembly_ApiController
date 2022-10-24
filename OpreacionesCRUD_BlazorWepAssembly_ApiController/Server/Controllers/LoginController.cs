using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Authentications;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private UserAccountServices accountServices;
        public LoginController(UserAccountServices accountServices)
        {
            this.accountServices = accountServices;
        }

        [HttpPost]
        [Route("Logins")]
        [AllowAnonymous]
        public ActionResult<UserSession> LoginsSession([FromBody] LoginRequest loginRequest)
        {
            var jwtAuthenticationManager = new JwtAuthenticationManager(accountServices);
            var userSession = jwtAuthenticationManager.GenereteJwtToken(loginRequest.UserName, loginRequest.Password);
            if (userSession is  null)
            {
                return Unauthorized();
            }
            else
            {
                return userSession;
            }

        }
        

    }
}
