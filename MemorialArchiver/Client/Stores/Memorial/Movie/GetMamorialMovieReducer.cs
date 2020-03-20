using Blazor.Fluxor;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class GetMamorialMovieReducer : Reducer<MemorialListState<Movie>, FetchMemorialItemsCompleteAction>
    {
        public override MemorialListState<Movie> Reduce(MemorialListState<Movie> state, FetchMemorialItemsCompleteAction action)
        {
            return new MemorialListState<Movie>(false, action.Memorials.Select(e => (Movie)e));
        }
    }
}
