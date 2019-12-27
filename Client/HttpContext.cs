using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace wasm.Client
{
    internal class HttpContext
    {
        private readonly HttpClient _restClient;

        public HttpContext()
        {
            _restClient = new HttpClient();
            _restClient.BaseAddress = new System.Uri("https://localhost:5001");
        }

        public async Task<T> GET<T>(string endpoint)
        {
            var result = await _restClient.GetJsonAsync<T>(endpoint);

            return result;
        }
    }
}