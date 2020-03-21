using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blazor.Fluxor;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorials;

namespace Dorisol1019.MemorialArchiver.Client.Stores
{
    public class AddMemorialItemAction<T>
    {
        public IMemorialCreateRequest<T> Request { get; }

        public AddMemorialItemAction(IMemorialCreateRequest<T> request)
        {
            Request = request;
        }
    }
}
