using System;
using System.Collections.Generic;
using System.Text;

namespace Dorisol1019.MemorialArchiver.Shared.Models.Memorial
{
    public class Movie : MemorialBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Movie()
        {
            Name = "";
        }

        public Movie(long id,string name)
        {
            Id = id;
            Name = name;
            Director = "";
            Thoughts = "";
        }
    }
}
