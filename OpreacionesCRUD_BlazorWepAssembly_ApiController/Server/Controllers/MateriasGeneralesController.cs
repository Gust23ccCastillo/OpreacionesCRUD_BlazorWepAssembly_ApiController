using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MateriasGeneralesController : ControllerBase
    {
          private readonly ApplicationsDBContext _dbContext;
        public MateriasGeneralesController(ApplicationsDBContext applicationsDBContext)
        {

            this._dbContext = applicationsDBContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<MateriasTotalesUni>>> GetMaterias()
        {
            return await _dbContext._materiasTotalesUni.ToListAsync();
        }

        [HttpGet("{id}", Name = "obtenerMateria")]
        public async Task<ActionResult<MateriasTotalesUni>> GetMaterias(int id)
        {
            return await _dbContext._materiasTotalesUni.FirstOrDefaultAsync(x => x.IdMaterias == id);
        }

        [HttpPost]
        public async Task<ActionResult> AgregarMaterias(MateriasTotalesUni materiasTotales)
        {
            _dbContext.Add(materiasTotales);
            await _dbContext.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerMateria", new { id = materiasTotales.IdMaterias }, materiasTotales);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarMaterias(int id)
        {
            var _MateriaGeneral = new MateriasTotalesUni { IdMaterias = id };
            _dbContext.Remove(_MateriaGeneral);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
