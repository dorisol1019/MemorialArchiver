using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Domain.User
{
    public class UserCreateRequest
    {
        public string Name { get; }

        public UserCreateRequest(string name)
        {
            Name = name;
        }
    }
}
