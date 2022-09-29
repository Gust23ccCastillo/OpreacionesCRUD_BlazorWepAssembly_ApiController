using Microsoft.EntityFrameworkCore;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server
{
    public class ApplicationsDBContext:DbContext
    {
        public ApplicationsDBContext(DbContextOptions<ApplicationsDBContext> options) :base(options)
        {

        }

        public DbSet<Usuarios> _usuarios { get; set; }
        //public DbSet<CarreraUniversidad> _carreraUniversidad { get; set; }
        //public DbSet<MateriasUniversidad> _materiasUniversidad { get; set; }
    }

}
