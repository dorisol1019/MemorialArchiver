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
    public class MovieController : BaseMemorialController<Movie>
    {
        public MovieController(IMemorialService<Movie> service) : base(service)
        {
        }
    }
}
