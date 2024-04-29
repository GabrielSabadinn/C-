using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemOfTasks.Models;

namespace SystemOfTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
