using Dorisol1019.MemorialArchiver.Shared.Models.Memorials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores
{
    public class AddMemorialItemCompleteAction<T>
    {
        public IMemorialCreateRequest<T> Request { get; }

        public AddMemorialItemCompleteAction(IMemorialCreateRequest<T> request)
        {
            Request = request;
        }
    }
}
