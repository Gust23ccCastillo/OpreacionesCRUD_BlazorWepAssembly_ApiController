using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarrerasGeneralesController : ControllerBase
    {
        private readonly ApplicationsDBContext _dbContext;
        public CarrerasGeneralesController(ApplicationsDBContext applicationsDBContext)
        {

            this._dbContext = applicationsDBContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<CarreraUniversidad>>> GetCarreras()
        {
            return await _dbContext._carreraUniversidad.ToListAsync();
        }
        [HttpGet("{id}", Name = "obtenerCarrera")]
        public async Task<ActionResult<CarreraUniversidad>> GetCarreras(int id)
        {
            return await _dbContext._carreraUniversidad.FirstOrDefaultAsync(x => x.IdCarrera == id);
        }

        [HttpPost]
        public async Task<ActionResult> AgregarCarrera(CarreraUniversidad carreraUniversidad)
        {
            _dbContext.Add(carreraUniversidad);
            await _dbContext.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerCarrera", new { id = carreraUniversidad.IdCarrera }, carreraUniversidad);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarCarrera(int id)
        {
            var _CarreraGeneral = new CarreraUniversidad { IdCarrera = id };
            _dbContext.Remove(_CarreraGeneral);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
