using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.Globalization;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace DotNet.WebApi.AppVeyor.Demo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "api/{controller}/{action}"
            );

            WebApiConfig.SetJsonSettings(config);
            WebApiConfig.SetGlobalCultureInfo();
        }

        private static void SetJsonSettings(HttpConfiguration config)
        {
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        private static void SetGlobalCultureInfo()
        {
            CultureInfo culture = CultureInfo.GetCultureInfo(ConfigurationManager.AppSettings["CultureInfo"]);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}
