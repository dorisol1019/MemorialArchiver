using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Server.Domain.Memorial
{
    public interface IMemorialRepository<T>
    {
        void Create(IMemorialCreateRequest<T> request);

        IEnumerable<T>? GetAll();
    }
}
