using System.Collections.Generic;

namespace abstract_document.Domains
{
    public class Part : AbstractDocument, IHasModel, IHasType, IHasPrice
    {
        public Part(IDictionary<string, object> partProperties) : base(partProperties)
        {
        }

        public string Type() => (string) Get(Property.Type.ToString());

        public string Model() => (string) Get(Property.Model.ToString());

        public long Price() => (long) Get(Property.Price.ToString());
    }
}