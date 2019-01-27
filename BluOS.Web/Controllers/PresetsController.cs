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

        [HttpGet("Presets")]
        public async Task Get()
        {
            await WriteXMLResponse(await BluOSService.GetStringAsync("Presets"));
        }

        [HttpGet("Play/{id}")]
        public async Task Play(int id)
        {
            await WriteXMLResponse(await BluOSService.GetStringAsync($"Preset?id={id}"));
        }
    }
}