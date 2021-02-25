namespace abstract_document.Domains
{
    public interface IHasModel : IDocument
    {
        public string Model() => (string) Get(Property.Model.ToString());
    }
}