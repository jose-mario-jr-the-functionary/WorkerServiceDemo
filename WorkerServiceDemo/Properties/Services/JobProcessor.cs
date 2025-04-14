using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WorkerServiceDemo.Services
{
    public class JobProcessor : IJobProcessor
    {
        private readonly ILogger<JobProcessor> _logger;

        public JobProcessor(ILogger<JobProcessor> logger)
        {
            _logger = logger;
        }

        public async Task ProcessJobAsync()
        {
            _logger.LogInformation("Processing job at {time}", DateTimeOffset.Now);

            // Simulate some work
            await Task.Delay(2000);

            _logger.LogInformation("Job completed at {time}", DateTimeOffset.Now);
        }
    }
}
