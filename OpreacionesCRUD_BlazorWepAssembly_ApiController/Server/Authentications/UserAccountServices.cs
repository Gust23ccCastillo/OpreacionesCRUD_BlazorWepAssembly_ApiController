using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Authentications
{
    public class UserAccountServices
    {
        private List<UserAccount> _UsuariosList;

        public UserAccountServices()
        {
            _UsuariosList = new List<UserAccount>
            {
                new UserAccount{UserName = "admin",Password ="1234", Role = "Administrator"},
                new UserAccount{UserName = "user",Password ="user1234", Role = "User"}
            };
        }
        public UserAccount? GetUserAccountByUserName(string _UserName)
        {

            return _UsuariosList.FirstOrDefault(x => x.UserName == _UserName);
        }
    }
}
