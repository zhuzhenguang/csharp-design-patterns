using Microsoft.AspNetCore.Mvc;

namespace inventory_microservice.Controllers
{
    [ApiController]
    public class InventoryController
    {
        [HttpGet]
        [Route("/inventories")]
        public int GetProductInventories() => 50;
    }
}