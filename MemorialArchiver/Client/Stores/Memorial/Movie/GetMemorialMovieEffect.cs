using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dorisol1019.MemorialArchiver.Shared.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Dorisol1019.MemorialArchiver.Shared.Models.Memorial;

namespace Dorisol1019.MemorialArchiver.Client.Stores.Memorial
{
    public class GetMemorialMovieEffect : Effect<FetchMemorialItemsAction>
    {
        private readonly HttpClient client;

        public GetMemorialMovieEffect(HttpClient client)
        {
            this.client = client;
        }

        protected override async Task HandleAsync(FetchMemorialItemsAction action, IDispatcher dispatcher)
        {
            try
            {
                var a = await client.GetJsonAsync<Movie[]>("api/Memorial/Movie");
                dispatcher.Dispatch(new FetchMemorialItemsCompleteAction<Movie>(a));
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
