using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blazor.Fluxor;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;

namespace Dorisol1019.MemorialArchiver.Client.Stores
{
    public class AddMemorialItemAction
    {
        public MovieCreateRequest Request { get; }

        public AddMemorialItemAction(MovieCreateRequest request)
        {
            Request = request;
        }
    }
}
