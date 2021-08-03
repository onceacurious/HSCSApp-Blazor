using Blazor.IntersectionObserver;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using HSCSApp.Shared.ClassLibrary;

namespace HSCSApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddIntersectionObserver();
            builder.Services.AddScoped<IFormValidations, FormValidations>();

            await builder.Build().RunAsync();
        }
    }
}