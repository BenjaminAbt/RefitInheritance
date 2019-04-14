using System.Threading.Tasks;
using Refit;

namespace Base.UnitTests
{

    public interface ITestRestClient : IBaseRestClient
    {
        [Get("/test")]
        Task<string> Test();
    }
}
