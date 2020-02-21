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
    [Route("api/Memorial/[Controller]")]
    [ApiController]
    public abstract class BaseMemorialController<T> : ControllerBase where T : MemorialBase
    {
        private IMemorialService<T> service;
        
        public BaseMemorialController(IMemorialService<T> service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<T> GetAll()
        {
            return service.GetAll();
        }

        [HttpPost]
        public void Post(IMemorialCreateRequest<T> request)
        {
            service.Create(request);
        }

        [HttpPost]
        public void Update()
        {

        }
    }
}
