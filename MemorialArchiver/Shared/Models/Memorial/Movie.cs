using System;
using System.Collections.Generic;
using System.Text;

namespace Dorisol1019.MemorialArchiver.Shared.Models.Memorial
{
    public class Movie : MemorialBase
    {
        public long Id { get; }
        public string Name { get; }
        public string Director { get; }

        public DateTime ReleaseDate { get; }

        public Movie()
        {

        }
    }
}
