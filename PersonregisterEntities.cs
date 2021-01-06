using System;
using System.Collections.Generic;

namespace Personlist
{
    internal class PersonregisterEntities : IDisposable
    {
        public IEnumerable<object> Person { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}