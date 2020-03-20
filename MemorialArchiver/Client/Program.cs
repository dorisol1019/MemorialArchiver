using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

using Blazor.Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Dorisol1019.MemorialArchiver.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddFluxor(options
               => options.UseDependencyInjection(typeof(Program).Assembly));
            builder.RootComponents.Add<App>("app");
            builder.Services.AddBaseAddressHttpClient();

            await builder.Build().RunAsync();
        }
    }
}
