using DotNet.WebApi.AppVeyor.Demo.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNet.WebApi.AppVeyor.Demo.Controllers
{
    public class HomeController : ApiControlle
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Home()
        {
            Message message = new Message();

            message.Title = "Hey Jude";
            message.Content = "don't make it bad";

            return Request.CreateResponse(HttpStatusCode.OK, message);
        }
    }
}