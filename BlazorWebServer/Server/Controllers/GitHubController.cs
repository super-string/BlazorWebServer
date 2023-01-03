using BlazorWebServer.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebServer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<GitHub> Get()
        {
            return new List<GitHub>()
            {
                new GitHub(){Name = "hoge"},
                new GitHub(){Name = "piyo"},
            }.ToArray();
        }
    }
}
