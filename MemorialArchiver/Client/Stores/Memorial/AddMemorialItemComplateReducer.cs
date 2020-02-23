using Blazor.Fluxor;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class AddMemorialItemComplateReducer : Reducer<MemorialState,AddMemorialItemCompleteAction>
    {
        public override MemorialState Reduce(MemorialState state, AddMemorialItemCompleteAction action)
        {
            // ここでStateを変更して返す
            MovieCreateRequest request = action.Request;

            return state;
        }
    }
}
