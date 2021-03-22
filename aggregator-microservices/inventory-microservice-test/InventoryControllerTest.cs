using inventory_microservice.Controllers;
using Xunit;

namespace inventory_microservice_test
{
    public class InventoryControllerTest
    {
        [Fact]
        public void should_get_product_inventories()
        {
            var inventoryController = new InventoryController();

            int inventories = inventoryController.GetProductInventories();

            Assert.Equal(50, inventories);
        }
    }
}