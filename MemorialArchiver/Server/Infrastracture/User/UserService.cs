using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dorisol1019.MemorialArchiver.Domain.User;

namespace Dorisol1019.MemorialArchiver.Infrastracture.User
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Create(UserCreateRequest request)
        {
            userRepository.Save(new UserEntity(request.Name));
        }

        public void Delete(UserDeleteRequest request)
        {
            throw new NotImplementedException("まだ作ってないでござる");
        }
    }
}
