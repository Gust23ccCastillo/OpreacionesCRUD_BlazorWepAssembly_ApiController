using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared.Modelos.InterfacesModelos;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ApplicationsDBContext _dbContext;
        public UsersController(ApplicationsDBContext applicationsDBContext)
        {

            this._dbContext = applicationsDBContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuarios>>> GetUsuarios()
        {
            return _dbContext._usuarios
                .Include(c=>c.CarreraEstudianteList)
                .Include(m=>m.MateriasEstudianteList)
                .ToList();
                
        }

        [HttpGet("{id}",Name = "obtenerUsuario")]
        public async Task<ActionResult<Usuarios>> GetUnUsuarios(int id)
        {
            return await _dbContext._usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> AgregarUsuario(Usuarios usuarios)
        {
            _dbContext.Add(usuarios);
            await _dbContext.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerUsuario", new {id = usuarios.Id},usuarios);
        }

        [HttpPut]
        public async Task<ActionResult> EditarUsuarios(Usuarios usuario)
        {
            _dbContext.Entry(usuario).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarUsuario(int id)
        {
           var Usuario = new Usuarios { Id = id };
            _dbContext.Remove(Usuario);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
