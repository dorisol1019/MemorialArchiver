using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Shared.Models.Memorial
{
    public interface IMemorialCreateRequest<T>
    {
        T ToEntity(long Id);
    }
}
