using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos
{
    public class MateriasUniversidad
    {
        [Key]
        public int IdMaterias { get; set; }

        [Required, StringLength(50)]
        public string ? NombresMaterias { get; set; }

        public CarreraUniversidad? _CarreraAsignada { get; set; }
    }

}
