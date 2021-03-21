using System.Threading.Tasks;

namespace aggregator_service.Applications
{
    public interface IProductInventoryClient
    {
        Task<int> GetProductInventories();
    }

    public class ProductInventoryHttpClient : IProductInventoryClient
    {
        public Task<int> GetProductInventories() => Task.Run((() => 5));
    }
}