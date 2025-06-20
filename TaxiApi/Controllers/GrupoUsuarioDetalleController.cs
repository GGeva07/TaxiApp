using Application.Interfaces;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace TaxiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrupoUsuarioDetalleController : ControllerBase
    {
        private readonly IGenericService<grupoUsuarioDetalle> _service;

        public GrupoUsuarioDetalleController(IGenericService<grupoUsuarioDetalle> service) 
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _service.GetByIdAsync(id);
            return entity != null ? Ok(entity) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] grupoUsuarioDetalle entity) 
        {
            await _service.CreateAsync(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] grupoUsuarioDetalle entity) 
        {
            if (id != entity.id) return BadRequest(); 
            await _service.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
