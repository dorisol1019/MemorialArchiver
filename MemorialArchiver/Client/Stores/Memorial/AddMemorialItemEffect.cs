using Blazor.Fluxor;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class AddMemorialItemEffect : Effect<AddMemorialItemAction>
    {

        private readonly HttpClient client;

        public AddMemorialItemEffect(HttpClient client)
        {
            this.client = client;
        }

        protected override async Task HandleAsync(AddMemorialItemAction action, IDispatcher dispatcher)
        {
            var request = action.Request;
            try
            {
                await client.PostJsonAsync("api/Memorial/Movie", action.Request);
            }
            catch (Exception)
            {
                throw;
            }
            dispatcher.Dispatch(new AddMemorialItemCompleteAction(request));
        }
    }
}
