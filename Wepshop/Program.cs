using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Wepshop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // IMPORTANT
            // Please make sure the goddamn IP is correct!
            
            builder.Services.AddScoped(_ => new HttpClient
                { BaseAddress = new Uri("https://192.168.236.145:5001") });
            
            // TODO
            // https://192.168.236.142:5001

            await builder.Build().RunAsync();
        }
    }
}