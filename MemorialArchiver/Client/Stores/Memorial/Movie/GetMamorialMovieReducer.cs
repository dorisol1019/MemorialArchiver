using Blazor.Fluxor;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class GetMamorialMovieReducer : Reducer<MemorialListState<Movie>, FetchMemorialItemsCompleteAction<Movie>>
    {
        public override MemorialListState<Movie> Reduce(MemorialListState<Movie> state, FetchMemorialItemsCompleteAction<Movie> action)
        {
            return new MemorialListState<Movie>(false, action.Memorials);
        }
    }
}
