using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class MemorialListState<T>
    {
        public bool IsLoading { get; }

        public T[] Memorials { get; }

        public MemorialListState()
        {
            Memorials = new T[0];
        }

        public MemorialListState(bool isLoading,IEnumerable<T> memorials)
        {
            IsLoading = isLoading;
            Memorials = memorials.ToArray();
        }
    }
}
