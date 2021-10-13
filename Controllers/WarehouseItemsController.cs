using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WareHouse_API.Models;
using WareHouse_API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WareHouse_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseItemsController : ControllerBase
    {
        private IUserService _userService;

        public WarehouseItemsController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// This call ishas the AllowAnonymous atribute to allow users to login
        /// It will only return the user details if the user is authorized
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateModel model)
        {
            var user = await _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        // GET: api/WarehouseItems
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            WarehouseItem warehouseItem = new WarehouseItem();
            return Ok(warehouseItem);

        }
        /* No need of other call types at this stage. */

    }
}
