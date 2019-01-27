using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace BluOS.Web.Controllers
{
    public abstract class BluOSController : ControllerBase
    {
        protected HttpClient BluOSService;
        protected BluOSController(IHttpClientFactory httpClientFactory)
        {
            BluOSService = httpClientFactory.CreateClient("BluOS");
        }

        protected async Task WriteXMLResponse(string bodyContent)
        {
            Response.ContentType = "application/xml";
            await Response.WriteAsync(bodyContent);
        }
    }
}
