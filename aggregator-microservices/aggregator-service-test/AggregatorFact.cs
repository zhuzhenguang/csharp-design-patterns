using System.Threading.Tasks;
using aggregator_service.Applications;
using aggregator_service.Controllers;
using aggregator_service.Domains;
using Moq;
using Xunit;

namespace aggregator_service_test
{
    public class AggregatorFact
    {
        [Fact]
        public async Task should_get_product()
        {
            const string title = "The Product Title";
            const int inventories = 5;
            var mockedInformationClient = new Mock<IProductInformationClient>();
            mockedInformationClient
                .Setup(c => c.GetProductTitle())
                .Returns(Task.Run(() => title));
            var mockedInventoryClient = new Mock<IProductInventoryClient>();
            mockedInventoryClient
                .Setup(c => c.GetProductInventories())
                .Returns(Task.Run(() => inventories));
            var aggregator = new Aggregator(mockedInformationClient.Object, mockedInventoryClient.Object);

            Product product = await aggregator.GetProduct();

            Assert.Equal(title, product.Title);
            Assert.Equal(inventories, product.Inventories);
        }
    }
}