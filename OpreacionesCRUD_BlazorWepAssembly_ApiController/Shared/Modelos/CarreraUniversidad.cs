using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos
{
    public  class CarreraUniversidad
    {
        [Key]
        public int IdCarrera { get; set; }

        [Required, StringLength(50)]
        public string ? NombreCarrera { get; set; }

        //public Usuarios? usuarios { get; set; }

        //public virtual List<MateriasUniversidad>? MateriasUniversidads { get; set; }
    }
}
