using Dorisol1019.MemorialArchiver.Server.Domain.Memorial;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Server.Infrastracture.Memorial
{
    public class InMemoryMemorialRepository<T> : IMemorialRepository<T>
    {
        private static Dictionary<long, T> dic = new Dictionary<long, T>();
        private static long id = 1;

        public void Create(IMemorialCreateRequest<T> request)
        {
            dic.Add(id, request.ToEntity(id));
            id++;
        }

        public IEnumerable<T>? GetAll()
        {
            if (!dic.Any())
            {
                return null;
            }
            return dic.Values;
        }
    }
}
