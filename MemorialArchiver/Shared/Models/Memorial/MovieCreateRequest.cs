using System;
using System.Collections.Generic;
using System.Text;

namespace Dorisol1019.MemorialArchiver.Shared.Models.Memorial
{
    public class MovieCreateRequest : IMemorialCreateRequest<Movie>
    {
        string Name { get; }

        public Movie ToEntity(long Id)
        {
            return new Movie();
        }
    }
}
