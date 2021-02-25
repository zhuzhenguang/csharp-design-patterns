using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace abstract_document.Domains
{
    public abstract class AbstractDocument : IDocument
    {
        private readonly IDictionary<string, object> properties;

        protected AbstractDocument([NotNull] IDictionary<string, object> properties)
        {
            this.properties = properties;
        }

        public void Put(string key, object value) => properties[key] = value;

        public object Get(string key) => properties[key];

        public IEnumerable<T> Children<T>(string key, Func<IDictionary<string, object>, T> constructor)
        {
            return ((IEnumerable<IDictionary<string, object>>) Get(key)).Select(constructor);
        }
    }
}