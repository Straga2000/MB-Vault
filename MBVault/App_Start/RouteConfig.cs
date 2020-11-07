using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MBVault
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Generate",
                url: "{controller}/{action}/{generator}/{password}",
                defaults: new
                {
                    controller = "Home",
                    action = "Generate",
                    generator = UrlParameter.Optional,
                    password = UrlParameter.Optional
                }
            );
        }
    }
}
