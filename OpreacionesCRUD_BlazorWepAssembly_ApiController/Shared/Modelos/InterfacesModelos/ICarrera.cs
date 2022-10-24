using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos
{
    public  interface ICarrera
    {
       
        public int IdCarrera { get; set; }

        public string? NombreCarrera { get; set; }

        public string? CodigoCarrera { get; set; }
    }
}
