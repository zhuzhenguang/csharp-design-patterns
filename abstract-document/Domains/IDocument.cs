using System;
using System.Collections.Generic;

namespace abstract_document.Domains
{
    public interface IDocument
    {
        void Put(string key, object value);
        object Get(string key);
        IEnumerable<T> Children<T>(string key, Func<IDictionary<string, object>, T> constructor);
    }
}