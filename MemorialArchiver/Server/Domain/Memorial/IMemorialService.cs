using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Server.Domain.Memorial
{
    public interface IMemorialService<T> where T : MemorialBase 
    {
        void Create(IMemorialCreateRequest<T> request);
        IEnumerable<T> GetAll();
        void Update(int id);
    }
}
