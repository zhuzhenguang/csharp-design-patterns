using System.Threading.Tasks;

namespace aggregator_service.Applications
{
    public interface IProductInformationClient
    {
        Task<string> GetProductTitle();
    }

    public class ProductInformationHttpClient : IProductInformationClient
    {
        public Task<string> GetProductTitle() => Task.Run(() => "a demo product");
    }
}