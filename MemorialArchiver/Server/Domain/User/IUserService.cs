using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Domain.User
{
    public interface IUserService
    {
        void Create(UserCreateRequest request);
        void Delete(UserDeleteRequest request);
    }
}
