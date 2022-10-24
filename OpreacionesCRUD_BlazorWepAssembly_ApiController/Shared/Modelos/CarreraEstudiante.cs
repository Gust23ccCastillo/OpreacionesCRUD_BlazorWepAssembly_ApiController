using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos
{
    public  class CarreraEstudiante:ICarrera
    {
        [Key]
        public int IdCarrera { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido!!."), StringLength(50)]
        public string ? NombreCarrera { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Requerido!!."), StringLength(50)]
        public string? CodigoCarrera { get; set; }


    }
}
