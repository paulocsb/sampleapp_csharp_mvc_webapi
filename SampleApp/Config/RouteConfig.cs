using System.Web.Mvc;
using System.Web.Routing;

namespace SampleApp.Config
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Slugs",
				url: "{slug}/{slug-subcategoria}",
				defaults: new { controller = "Home", action = "Formulario" });

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}