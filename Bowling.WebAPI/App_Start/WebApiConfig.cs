using System.Web.Http;

namespace Bowling.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
             name: "DefaultHttpRouteWithAction",
             routeTemplate: "{controller}/{action}/{id}",
             defaults: new { id = RouteParameter.Optional }
        );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
