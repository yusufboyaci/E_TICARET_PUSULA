using DATAACCESS.Context;
using DATAACCESS.Repositories.Concrete;
using ENTITIES;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        BasketRepository _basketRepository;
        public BasketController(AppDbContext context)
        {
            _basketRepository = new BasketRepository(context);
        }
        [HttpGet("List")]
        public IActionResult List()
        {
            try
            {
                List<Basket> list = _basketRepository.GetActive();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("Get")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_basketRepository.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(Basket basket)
        {
            try
            {
                _basketRepository.Add(basket);
                _basketRepository.Activate(basket.Id);
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut("Update")]
        public IActionResult Update(Basket basket)
        {
            try
            {
                _basketRepository.Update(basket);
                _basketRepository.Activate(basket.Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Basket basket)
        {
            try
            {
                _basketRepository.Remove(basket);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
