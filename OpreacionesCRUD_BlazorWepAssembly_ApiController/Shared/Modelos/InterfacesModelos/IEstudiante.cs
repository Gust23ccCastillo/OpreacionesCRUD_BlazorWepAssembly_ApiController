using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos
{
    public interface IEstudiante
    {

        public string? Nombre { get; set; }

        public string? Cuatrimestre { get; set; }

        public List<CarreraEstudiante> CarreraEstudianteList { get; set; }

        public List<MateriasEstudiante> MateriasEstudianteList { get; set; } 
    }
}
