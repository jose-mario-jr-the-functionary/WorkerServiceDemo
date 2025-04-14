using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerServiceDemo.Services;

var builder = Host.CreateApplicationBuilder(args);
builder.ConfigureServices((hostContext, services) =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<IJobProcessor, JobProcessor>();
    });

var host = builder.Build();
host.Run();
