using information_microservice.Controllers;
using Xunit;

namespace information_microservice_test
{
    public class InformationFact
    {
        [Fact]
        public void should_get_product_title()
        {
            var informationController = new InformationController();

            string productTitle = informationController.GetProductTitle();
            
            Assert.Equal("The Product Title", productTitle);
        }
    }
}