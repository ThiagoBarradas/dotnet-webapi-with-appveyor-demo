using DotNet.WebApi.AppVeyor.Demo.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNet.WebApi.AppVeyor.Demo.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Home()
        {
            Message message = new Message();

            message.Title = "Hey Jude";
            message.Content = "don't let me down";

            return Request.CreateResponse(HttpStatusCode.OK, message);
        }
    }
}