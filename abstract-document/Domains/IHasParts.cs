using System.Collections.Generic;

namespace abstract_document.Domains
{
    public interface IHasParts : IDocument
    {
        public IEnumerable<Part> Parts() =>
            Children(
                Property.Parts.ToString(),
                parts => new Part(parts));
    }
}