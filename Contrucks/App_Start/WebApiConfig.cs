using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Contrucks
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));          //text/html
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;

            //To serialize output 
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //

            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
