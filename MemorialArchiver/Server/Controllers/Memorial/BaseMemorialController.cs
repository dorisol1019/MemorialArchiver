using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dorisol1019.MemorialArchiver.Server.Domain.Memorial;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dorisol1019.MemorialArchiver.Server.Controllers.Memorial
{
    internal class BaseMemorialController<T> : ControllerBase where T : MemorialBase
    {
        private IMemorialService<T> service;

        public BaseMemorialController(IMemorialService<T> service)
        {
            this.service = service;
        }

        public IEnumerable<T> GetAll()
        {
            return service.GetAll();
        }

        public void Post(IMemorialCreateRequest<T> request)
        {
            service.Create(request);
        }
    }
}
