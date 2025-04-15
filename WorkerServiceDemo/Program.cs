using WorkerServiceDemo;
using WorkerServiceDemo.Services;

var builder = Host.CreateApplicationBuilder(args);

// Register services
builder.Services.AddHostedService<Worker>();
builder.Services.AddSingleton<IJobProcessor, JobProcessor>();

var app = builder.Build();
app.Run();
