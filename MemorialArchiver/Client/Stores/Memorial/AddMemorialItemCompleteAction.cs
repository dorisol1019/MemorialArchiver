using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores
{
    public class AddMemorialItemCompleteAction
    {
        public MovieCreateRequest Request { get; }

        public AddMemorialItemCompleteAction(MovieCreateRequest request)
        {
            Request = request;
        }
    }
}
