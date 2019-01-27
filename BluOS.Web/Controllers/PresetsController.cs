using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace BluOS.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PresetsController : BluOSController
    {
        public PresetsController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        [HttpGet]
        public async Task Get()
        {
            await WriteXMLResponse(await BluOSService.GetStringAsync("Presets"));
        }

    }
}