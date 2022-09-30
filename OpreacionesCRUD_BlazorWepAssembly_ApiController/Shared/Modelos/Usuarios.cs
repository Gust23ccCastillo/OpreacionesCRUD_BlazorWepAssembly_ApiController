using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos
{
    public class Usuarios
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El Campo {0} es Requerido!!."),StringLength(20)]
        public string ? Nombre { get; set; }


        [Required(ErrorMessage = "El Campo {0} es Requerido!!."),StringLength(20)]
        public string ? Correo { get; set; }


        [Required(ErrorMessage = "El Campo {0} es Requerido!!."),StringLength(25)]
        public string ? Clave { get; set; }


        [Required(ErrorMessage = "El Campo {0} es Requerido!!."), StringLength(100)]
        public string ? Roles { get; set; }

        [Required,StringLength(500)]
        public string? carreras { get; set; }

        [Required, StringLength(500)]
        public string? Materias { get; set; }


    }
}
