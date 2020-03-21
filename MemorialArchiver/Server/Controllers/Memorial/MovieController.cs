using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dorisol1019.MemorialArchiver.Server.Domain.Memorial;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorials;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dorisol1019.MemorialArchiver.Server.Controllers.Memorial
{
    [Route("api/Memorial/[Controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        BaseMemorialController<Movie> controller;

        public MovieController(IMemorialService<Movie> service)
        {
            controller = new BaseMemorialController<Movie>(service);
        }

        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return controller.GetAll();
        }

        [HttpPost]
        public void Post(MovieCreateRequest request)
        {
            controller.Post(request);
        }
    }
}
