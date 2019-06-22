using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Detail",
                url: "Offer/Detail/{id}",
                defaults: new { controller = "Offer", action = "Detail", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "List",
                url: "Offer/List",
                defaults: new { controller = "Offer", action = "List" }
            );

            routes.MapRoute(
                name: "ApplyForm",
                url: "Postulation/ApplyForm/{offerId}",
                defaults: new { controller = "Postulation", action = "ApplyForm", offerId = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "PostulationList",
                url: "Postulation/List",
                defaults: new { controller = "Postulation", action = "List" }
            );

            routes.MapRoute(
                name: "Error",
                url: "Error/Index",
                defaults: new { controller = "Error", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
