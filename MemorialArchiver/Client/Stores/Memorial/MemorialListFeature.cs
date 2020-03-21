using Blazor.Fluxor;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorials;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class MemorialListFeature : Feature<MemorialListState<Movie>>
    {
        public override string GetName() => "MemorialList";

        protected override MemorialListState<Movie> GetInitialState()
        {
            return new MemorialListState<Movie>(true, new Movie[0]);
        }
    }
}
