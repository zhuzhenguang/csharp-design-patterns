using System.Collections.Generic;
using System.Linq;
using abstract_document.Domains;
using Xunit;

namespace abstract_document.Facts
{
    public class AbstractDocumentFact
    {
        private const string Key = "key";
        private const string Value = "value";


        [Fact]
        public void should_put_and_get_value()
        {
            AbstractDocument document = new ImplementAbstractDocument(new Dictionary<string, object>());

            document.Put(Key, Value);
            var value = document.Get(Key);

            Assert.Equal(Value, value);
        }

        [Fact]
        public void should_retrieve_children()
        {
            AbstractDocument document = new ImplementAbstractDocument(new Dictionary<string, object>());
            var children = new List<IDictionary<string, object>>
            {
                new Dictionary<string, object>(),
                new Dictionary<string, object>()
            };
            
            document.Put(Key, children);

            IEnumerable<ImplementAbstractDocument> childrenResult = document.Children(
                Key,
                properties => new ImplementAbstractDocument(properties));
            Assert.Equal(2, childrenResult.Count());
        }
    }

    internal class ImplementAbstractDocument : AbstractDocument
    {
        public ImplementAbstractDocument(IDictionary<string, object> properties) : base(properties)
        {
        }
    }
}