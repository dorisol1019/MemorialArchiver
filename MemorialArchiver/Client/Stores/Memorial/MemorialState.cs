using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class MemorialState
    {
        public string Name { get; }

        public string ErrorMessage { get; }

        public MemorialState()
        {
            Name = "";
            ErrorMessage = "";
        }

        public MemorialState(string name,string errorMessage)
        {
            Name = name;
            ErrorMessage = errorMessage;
        }

    }
}
