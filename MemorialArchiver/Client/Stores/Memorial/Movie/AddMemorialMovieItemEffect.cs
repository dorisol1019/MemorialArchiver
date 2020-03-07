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
    public class AddMemorialMovieItemEffect : Effect<AddMemorialItemAction<Movie>>
    {

        private readonly HttpClient client;

        public AddMemorialMovieItemEffect(HttpClient client)
        {
            this.client = client;
        }

        protected override async Task HandleAsync(AddMemorialItemAction<Movie> action, IDispatcher dispatcher)
        {
            var request = action.Request;
            try
            {
                string uri = RequestURI(request);
                await client.PostJsonAsync(uri, action.Request);
            }
            catch (Exception)
            {
                throw;
            }
            dispatcher.Dispatch(new AddMemorialItemCompleteAction<Movie>(request));
        }

        private string RequestURI(IMemorialCreateRequest<Movie> request)
        {
            string baseUri = "api/Memorial/";
            if(request is MovieCreateRequest)
            {
                return baseUri + "Movie";
            }
            throw new InvalidOperationException();
        }
    }
}
