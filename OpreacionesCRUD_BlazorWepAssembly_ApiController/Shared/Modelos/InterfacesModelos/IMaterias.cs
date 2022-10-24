using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos
{
    public interface IMaterias
    {
        public int IdMaterias { get; set; }

        public string? NombresMaterias { get; set; }
    }
}
