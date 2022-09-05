using ConsoleApp11;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddScoped<IMyInterface, MyService1>()
                .AddScoped<IMyInterface, MyService2>())          
    .Build();


RunTest(host.Services);

await host.RunAsync();


static void RunTest(IServiceProvider services)
{   
    var foundServices = services.GetServices<IMyInterface>();
    var service = foundServices.First(a => a.TestId == "1");
    service.Test();
    
}