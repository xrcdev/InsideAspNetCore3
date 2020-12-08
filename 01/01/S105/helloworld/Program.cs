using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace helloworld
{
    class Program
    {
        static void Main()
        {
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webHostBuilder => webHostBuilder
                    .ConfigureServices(servicecs => servicecs
                        .AddRouting()
                        .AddControllersWithViews())
                    .Configure(app => app
                        .UseRouting()
                        .UseEndpoints(endpoints => endpoints.MapControllers())))
                .Build()
                .Run();

            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(cf => cf
                    .Configure( app => app
                        .Run( context => context.Response.WriteAsync("Hello World.")))) 
                .Build()
                .Run();
        }
    }
}
