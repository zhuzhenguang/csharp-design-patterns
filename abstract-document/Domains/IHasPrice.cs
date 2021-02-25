namespace abstract_document.Domains
{
    public interface IHasPrice : IDocument
    {
        public long Price() => (long) Get(Property.Price.ToString());
    }
}