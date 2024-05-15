using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerApi.Models;
using ServerApi.Repository;

namespace ServerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        private readonly IFactoryRepository _factoryRepository;
        public FactoryController(IFactoryRepository factoryRepository)
        {
            _factoryRepository = factoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetFactorys()
        {
            try
            {
                var factories = await _factoryRepository.GetFactoryDtoAsync();
                return Ok(factories);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFactoryById(int id)
        {
            try
            {
                var factories = await _factoryRepository.GetFactoryDtoByIdAsync(id);
                if (factories == null)
                    return NotFound();
                return Ok(factories);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddFactory([FromBody] FactoryDto factories)
        {
            try
            {
                await _factoryRepository.AddFactoryDtoAsync(factories);
                return CreatedAtAction(nameof(GetFactoryById), new { id = factories.MaNCC }, factories);
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFactory(int id, [FromBody] FactoryDto factories)
        {
            try
            {
                if (id != Convert.ToInt32(factories.MaNCC))
                    return BadRequest();
                await _factoryRepository.UpdateFactoryDtoAsync(factories);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFactory(int id)
        {
            try
            {
                await _factoryRepository.DeleteFactoryDtoAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exception
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
