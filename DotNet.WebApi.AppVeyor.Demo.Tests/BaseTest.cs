using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNet.WebApi.AppVeyor.Demo.Controllers;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using System.Net;

namespace DotNet.WebApi.AppVeyor.Demo.Tests
{
    public class BaseTest
    {
        public T GenerateController<T>(HttpRequestMessage request = null) 
            where T : ApiController, new()
        {
            var controller = new T();

            var config = new HttpConfiguration();
            var route = new HttpRouteData(new HttpRoute());
            if (request == null) request = new HttpRequestMessage();

            controller.ControllerContext = new HttpControllerContext(config, route, request);
            controller.Request = request;

            return controller;
        }
    }
}
