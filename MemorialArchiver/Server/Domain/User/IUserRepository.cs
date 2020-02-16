using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Domain.User
{
    public interface IUserRepository
    {
        UserEntity? FindByName(string name);
        UserEntity? FindById(long id);
        void Save(UserEntity user);
        void Delete(UserEntity user);
    }
}
