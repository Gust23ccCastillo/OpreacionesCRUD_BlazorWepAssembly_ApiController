using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Client.Extensions;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared;
using System.Security.Claims;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Client.Authentications
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ISessionStorageService _sessionStorage;
        //CLAIMS PARA USUARIOS SIN INICIAR SESION
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var userSession = await _sessionStorage.ReadEncryptedItemAsync<UserSession>("UserSession");
                if(userSession == null)
                    return await Task.FromResult(new AuthenticationState(_anonymous));
                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userSession.UserName),
                    new Claim(ClaimTypes.Role, userSession.Role),
                }, "JwtAuth"));

                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            }
            catch 
            {

                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }

        //metodo para cuando inia sesion o cierre sesion 
        public async Task UpdateAuthenticationState(UserSession? userSession)
        {
            ClaimsPrincipal claimsPrincipal;
            if(userSession != null)
            {
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userSession.UserName),
                    new Claim(ClaimTypes.Role, userSession.Role)
                }));
                //para comprobar si el token a caducado o no
                userSession.ExpiryTimesStamp = DateTime.Now.AddSeconds(userSession.ExpiresIn);
                await _sessionStorage.SaveItemEncryptedAsync("UserSession", userSession);

            }
            else
            {
                claimsPrincipal = _anonymous;
                await _sessionStorage.RemoveItemAsync("UserSession");
            }
            //cambio de estado de autenticacion se llama a este metodo
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));


        }

        //Meotod para que los componentes razor obtengan el jwt del almacenamiento de la sesion.
        public async Task<string> GetToken()
        {
            var result = string.Empty;
            try
            {
                var userSession = await _sessionStorage.ReadEncryptedItemAsync<UserSession>("UserSession");
                if (userSession != null && DateTime.Now < userSession.ExpiryTimesStamp)
                    result = userSession.Token;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
            
        }
    }
}
