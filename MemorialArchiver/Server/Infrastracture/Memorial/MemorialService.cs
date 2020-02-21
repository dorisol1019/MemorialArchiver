using Dorisol1019.MemorialArchiver.Server.Domain.Memorial;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Server.Infrastracture.Memorial
{
    public class MemorialService<T> : IMemorialService<T> where T : MemorialBase
    {
        IMemorialRepository<T> repository;

        public MemorialService(IMemorialRepository<T> repository)
        {
            this.repository = repository;
        }

        public void Create(IMemorialCreateRequest<T> request)
        {
            repository.Create(request);
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
