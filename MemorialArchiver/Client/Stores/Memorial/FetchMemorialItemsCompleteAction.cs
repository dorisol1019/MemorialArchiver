using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class FetchMemorialItemsCompleteAction
    {
        public MemorialBase[] Memorials { get; }

        public FetchMemorialItemsCompleteAction(IEnumerable<MemorialBase> memorials)
        {
            Memorials = memorials.ToArray();
        }
    }
}
