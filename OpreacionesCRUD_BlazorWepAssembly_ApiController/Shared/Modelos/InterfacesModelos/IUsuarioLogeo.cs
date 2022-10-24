using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos
{
    public interface IUsuarioLogeo
    {
        public string? Correo { get; set; }
        public string? Clave { get; set; }

        public string? Roles { get; set; }
    }
}
