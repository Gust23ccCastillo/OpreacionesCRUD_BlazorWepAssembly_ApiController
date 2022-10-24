using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos
{
    public class Usuarios:IUsuarioLogeo,IEstudiante
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

        [Required(ErrorMessage = "El Campo {0} es Requerido!!."), StringLength(15)]
        public string? Cuatrimestre { get; set; }

        public List<CarreraEstudiante> CarreraEstudianteList { get; set; } = new List<CarreraEstudiante>();

        public List<MateriasEstudiante> MateriasEstudianteList { get; set; } = new List<MateriasEstudiante>();
        

        //[Required,StringLength(500)]
        //public string? carreras { get; set; }

        //[Required, StringLength(500)]
        //public string? Materias { get; set; }


    }
}
