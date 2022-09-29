using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos
{
    public interface IEstudiante
    {
      
        public string? Nombre { get; set; }

        public string? Materias { get; set; }

        public string? carreras { get; set; }
    }
}
