using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectosWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Rutas limpias
            routes.MapRoute(
                name: "Nosotros",
                url: "Nosotros",
                defaults: new { controller = "Home", action = "Nosotros" }
            );

            routes.MapRoute(
                name: "Contactanos",
                url: "Contactanos",
                defaults: new { controller = "Home", action = "Contactanos" }
            );

            // Ruta por defecto
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Inicio", id = UrlParameter.Optional }
            );
        }
    }

}
