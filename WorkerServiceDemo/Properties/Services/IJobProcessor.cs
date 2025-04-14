using System.Threading.Tasks;

namespace WorkerServiceDemo.Services
{
    public interface IJobProcessor
    {
        Task ProcessJobAsync();
    }
}
