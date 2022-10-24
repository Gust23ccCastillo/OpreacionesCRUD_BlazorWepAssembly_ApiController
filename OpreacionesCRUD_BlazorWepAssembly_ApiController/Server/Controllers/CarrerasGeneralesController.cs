using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos;

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
        public async Task<ActionResult<List<CarrerasTotalesUni>>> GetCarreras()
        {
            return await _dbContext._carrerasTotalesUnis.ToListAsync();
        }

        [HttpGet("{id}", Name = "obtenerCarrera")]
        public async Task<ActionResult<CarrerasTotalesUni>> GetCarreras(int id)
        {
            return await _dbContext._carrerasTotalesUnis.FirstOrDefaultAsync(x => x.IdCarrera == id);
        }

        [HttpPost]
        public async Task<ActionResult> AgregarCarrera(CarrerasTotalesUni carrerasTotalesUni)
        {
            _dbContext.Add(carrerasTotalesUni);
            await _dbContext.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerCarrera", new { id = carrerasTotalesUni.IdCarrera }, carrerasTotalesUni);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarCarrera(int id)
        {
            var _CarreraGeneral = new CarrerasTotalesUni { IdCarrera = id };
            _dbContext.Remove(_CarreraGeneral);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
