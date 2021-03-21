using System.Threading.Tasks;
using aggregator_service.Applications;
using aggregator_service.Domains;
using Microsoft.AspNetCore.Mvc;

namespace aggregator_service.Controllers
{
    [ApiController]
    [Route("/aggregator")]
    public class Aggregator 
    {
        private readonly IProductInformationClient informationClient;
        private readonly IProductInventoryClient inventoryClient;

        public Aggregator(IProductInformationClient informationClient, IProductInventoryClient inventoryClient)
        {
            this.informationClient = informationClient;
            this.inventoryClient = inventoryClient;
        }

        [HttpGet]
        [Route("product")]
        public async Task<Product> GetProduct()
        {
            Task<string> productTitle = informationClient.GetProductTitle();
            Task<int> productInventories = inventoryClient.GetProductInventories();

            return new Product(await productTitle, await productInventories);
        }
    }
}