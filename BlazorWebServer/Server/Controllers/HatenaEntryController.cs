using Microsoft.AspNetCore.Mvc;

namespace BlazorWebServer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HatenaEntryController : ControllerBase
    {
        private readonly HttpClient _client;
        public HatenaEntryController(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("HatenaEntry");
        }

        [HttpGet]
        public string Get()
        {
            return GetAsync().Result;
        }

        private async Task<string> GetAsync()
        {
            var ret = await _client.GetAsync("entry");
            if (!ret.IsSuccessStatusCode)
            {
                return string.Empty;
            }
            return await ret.Content.ReadAsStringAsync();
        }
    }
}
