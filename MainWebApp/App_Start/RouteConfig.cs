﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace MainWebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new
             {
                 controller = "Home",
                 action = "Index",
                 id = UrlParameter.Optional
             });

           routes.MapRoute(
          name: "Equipment",
          url: "{controller}/{action}/{id}",
          defaults: new
          {
              controller = "Equipment",
              action = "Index",
              id = UrlParameter.Optional
          });

            routes.MapRoute(
        name: "Repairs",
        url: "{controller}/{action}/{id}",
        defaults: new
        {
            controller = "Repairs",
            action = "Index",
            id = UrlParameter.Optional
        });
        }
    }
}
