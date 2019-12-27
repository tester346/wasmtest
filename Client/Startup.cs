using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Text.Json;

namespace wasm.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<HttpContext>();
            //var configuration = JsonSerializer.Deserialize<Configuration>(File.ReadAllText("appsettings.json"));
            //services.AddSingleton(configuration);
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
