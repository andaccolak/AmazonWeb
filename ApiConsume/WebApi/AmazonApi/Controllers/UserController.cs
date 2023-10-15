using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]   
        public  IActionResult UserList()
        {
            
            var values = _userService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.TInsert(user);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            var values = _userService.TGetById(id);
            _userService.TDelete(values);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var values = _userService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            _userService.TUpdate(user);
            return Ok();
        }
    }
}
