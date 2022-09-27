using API.ViewModels;
using DATAACCESS.Context;
using DATAACCESS.Repositories.Concrete;
using ENTITIES;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        UserRepository _userRepository;
        public UserController(AppDbContext context)
        {
            _userRepository = new UserRepository(context);
        }
        [HttpGet("List")]
        public IActionResult List()
        {
            try
            {
                List<User> list = _userRepository.GetActive();
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
                return Ok(_userRepository.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost("Add")]
        public IActionResult Add(User user)
        {
            try
            {
                _userRepository.Add(user);
                _userRepository.Activate(user.Id);
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut("Update")]
        public IActionResult Update(User user)
        {
            try
            {
                _userRepository.Update(user);
                _userRepository.Activate(user.Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(User user)
        {
            try
            {
                _userRepository.Remove(user);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginVM login)
        {
            try
            {
            bool result = _userRepository.CheckCredential(login.UserName, login.Password);
            return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
