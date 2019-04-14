using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace Base
{
    public interface IBaseRestClient
    {
        HttpClient Client { get; }

        [Get("/version")]
        Task<string> GetVersion();
    }
}
