using System.Collections.Generic;

namespace abstract_document.Domains
{
    public class Car : AbstractDocument, IHasParts, IHasModel, IHasPrice
    {
        public Car(IDictionary<string, object> partProperties) : base(partProperties)
        {
        }
    }
}