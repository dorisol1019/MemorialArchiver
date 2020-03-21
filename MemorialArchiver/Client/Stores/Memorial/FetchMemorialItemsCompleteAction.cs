using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class FetchMemorialItemsCompleteAction<T>
    {
        public T[] Memorials { get; }

        public FetchMemorialItemsCompleteAction(IEnumerable<T> memorials)
        {
            Memorials = memorials.ToArray();
        }
    }
}
