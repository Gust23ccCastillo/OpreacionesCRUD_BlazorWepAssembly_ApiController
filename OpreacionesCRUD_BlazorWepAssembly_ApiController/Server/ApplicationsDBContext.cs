using Microsoft.EntityFrameworkCore;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server
{
    public class ApplicationsDBContext:DbContext
    {
        public ApplicationsDBContext(DbContextOptions<ApplicationsDBContext> options) :base(options)
        {


        }

        public DbSet<Usuarios> _usuarios { get; set; }
        public DbSet<CarreraEstudiante> _carreraEstudiante { get; set; }

        public DbSet<CarrerasTotalesUni> _carrerasTotalesUnis { get; set; }
        public DbSet<MateriasEstudiante> _materiasEstudiante { get; set; }

        public DbSet<MateriasTotalesUni> _materiasTotalesUni { get; set; }


    }

}
