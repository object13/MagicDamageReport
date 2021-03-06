﻿using System.Web.Mvc;
using System.Web.Routing;

namespace MDR.Web
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

            //routes.MapRoute(
            //    name: "mdrApp",
            //    url: "{*.}",
            //    defaults: new { controller = "Home", action = "Index" }
            //);
        }
    }
}
