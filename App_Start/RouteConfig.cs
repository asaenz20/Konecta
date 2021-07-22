using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Konecta
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Solicitudes",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Solicitudes", action = "Index",id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Empleados",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Empleados", action = "Index" , id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
