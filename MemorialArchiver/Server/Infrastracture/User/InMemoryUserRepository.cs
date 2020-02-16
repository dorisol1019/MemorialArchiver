using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dorisol1019.MemorialArchiver.Domain.User;


namespace Dorisol1019.MemorialArchiver.Infrastracture.User
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly Dictionary<long, UserEntity> dic = new Dictionary<long, UserEntity>();

        public void Delete(UserEntity user)
        {
            dic.Remove(user.Id);
        }

        public UserEntity? FindById(long id)
        {
            dic.TryGetValue(id, out UserEntity? user);
            return user;
        }

        public UserEntity? FindByName(string name)
        {
            return dic.Select(e => e.Value).FirstOrDefault(e => e.Name == name);
        }

        public void Save(UserEntity user)
        {
            dic.Add(user.Id, user);
        }
    }
}
