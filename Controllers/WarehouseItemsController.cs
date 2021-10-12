using Microsoft.AspNetCore.Mvc;
using WareHouse_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WareHouse_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseItemsController : ControllerBase
    {
        // GET: api/WarehouseItems
        [HttpGet]
        public WarehouseItem Get()
        {
            WarehouseItem warehouseItem = new WarehouseItem();
            return warehouseItem;

        }
        /* No need of overloading the GET or any other call types at this stage.*/

        //// GET api/<WarehouseItemsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
    }
}
