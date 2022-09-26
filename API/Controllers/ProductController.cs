using DATAACCESS.Context;
using DATAACCESS.Repositories.Concrete;
using ENTITIES;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository _productRepository;
        public ProductController(AppDbContext context)
        {
            _productRepository = new ProductRepository(context);
        }
        [HttpGet("List")]
        public IActionResult List()
        {
            try
            {
                List<Product> list = _productRepository.GetActive();
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
                return Ok(_productRepository.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {
            try
            {
                _productRepository.Add(product);
                _productRepository.Activate(product.Id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut("Update")]
        public IActionResult Update(Product product)
        {
            try
            {
                _productRepository.Update(product);
                _productRepository.Activate(product.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Product product)
        {
            try
            {
                _productRepository.Remove(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
