using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace aggregator_service.Applications
{
    public interface IProductInformationClient
    {
        Task<string> GetProductTitle();
    }

    public class ProductInformationHttpClient : IProductInformationClient
    {
        public async Task<string> GetProductTitle()
        {
            HttpResponseMessage response;
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(new Uri("https://localhost:6001/information"));
            }

            return await response.Content.ReadAsStringAsync();
        }
    }
}