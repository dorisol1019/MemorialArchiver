using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Shared.Models.Memorials
{
    public interface IMemorialCreateRequest<T>
    {
        T ToEntity(long Id);
    }
}
