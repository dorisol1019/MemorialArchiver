using System;
using System.Collections.Generic;
using System.Text;

namespace Dorisol1019.MemorialArchiver.Shared.Models.Memorial
{
    public class MovieCreateRequest : IMemorialCreateRequest<Movie>
    {
        public string Name { get; set; }

        public MovieCreateRequest() {
            Name = "";
        }

        public MovieCreateRequest(string name)
        {
            Name = name;
        }

        public Movie ToEntity(long Id)
        {
            return new Movie(Id, Name);
        }
    }
}
