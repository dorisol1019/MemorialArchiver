using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Domain.User
{
    public class UserEntity
    {
        public long Id { get; }
        public string Name { get; }

        public UserEntity(string name)
        {
            Name = name;
        }
    }
}
