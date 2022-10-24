using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos
{
    public class MateriasEstudiante:IMaterias
    {
        [Key]
        public int IdMaterias { get; set; }

        [Required, StringLength(250)]
        public string ? NombresMaterias { get; set; }

        
    }

}
