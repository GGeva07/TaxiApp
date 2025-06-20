using Application.Interfaces;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace TaxiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class viajeDetalleController : ControllerBase
    {
        private readonly IGenericService<detalleViaje> _service;

        public viajeDetalleController(IGenericService<detalleViaje> service) 
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
        public async Task<IActionResult> Create([FromBody] detalleViaje entity) 
        {
            await _service.CreateAsync(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] detalleViaje entity) 
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
