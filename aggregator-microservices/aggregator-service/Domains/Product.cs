namespace aggregator_service.Domains
{
    public class Product
    {
        public Product(string title, int inventories)
        {
            Title = title;
            Inventories = inventories;
        }

        public string Title { get; }
        public int Inventories { get; }
    }
}