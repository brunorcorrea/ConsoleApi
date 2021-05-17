using Refit;
using System.Threading.Tasks;

namespace ConsoleApi
{
    public interface ApiService
    {
        [Get("/series/list/")]
        Task<dynamic> GetSeriesAsync();

    }
}
