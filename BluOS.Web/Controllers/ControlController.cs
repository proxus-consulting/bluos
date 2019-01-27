using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace BluOS.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ControlController : BluOSController
    {
        public ControlController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        [HttpGet("Play")]
        public async Task Play()
        {
            await WriteXMLResponse(await BluOSService.GetStringAsync("Play"));
        }

        [HttpGet("Pause")]
        public async Task Pause()
        {
            await WriteXMLResponse(await BluOSService.GetStringAsync("Pause"));
        }
    }
}