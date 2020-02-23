using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blazor.Fluxor;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class MemorialFeature : Feature<MemorialState>
    {
        public override string GetName()
        {
            return "Memorial1";
        }

        protected override MemorialState GetInitialState()
        {
            return new MemorialState();
        }
    }
}
