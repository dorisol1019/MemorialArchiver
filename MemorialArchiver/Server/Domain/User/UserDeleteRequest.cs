using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Domain.User
{
    public class UserDeleteRequest
    {
        public long Id { get; }

        public UserDeleteRequest(long id)
        {
            Id = id;
        }
    }
}
