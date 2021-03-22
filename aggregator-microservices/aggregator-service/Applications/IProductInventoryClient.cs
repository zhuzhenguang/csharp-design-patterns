using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace aggregator_service.Applications
{
    public interface IProductInventoryClient
    {
        Task<int> GetProductInventories();
    }

    public class ProductInventoryHttpClient : IProductInventoryClient
    {
        public async Task<int> GetProductInventories()
        {
            HttpResponseMessage response;
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(new Uri("https://localhost:7001/inventories"));
            }

            return int.Parse(await response.Content.ReadAsStringAsync());
        }
    }
}