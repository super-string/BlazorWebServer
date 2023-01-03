using BlazorWebServer.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebServer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
        private readonly HttpClient _client;
        public GitHubController(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("GitHubRestApi");
        }
        [HttpGet]
        public IEnumerable<GitHub> Get()
        {
            return GetAsync().Result;
        }

        private async Task<IEnumerable<GitHub>> GetAsync()
        {
            var ret = await _client.GetAsync("/traffic");
            return await ret.Content.ReadFromJsonAsync<GitHub[]>();
        }
    }
}
