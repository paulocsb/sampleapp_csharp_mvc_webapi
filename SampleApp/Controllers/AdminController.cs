using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View("Formulario/Index");
        }

		public ActionResult Categoria()
		{
			var formularioId = Convert.ToInt32(Request["fId"]);
			return View("Categoria/Index", formularioId);
		}

		public ActionResult SubCategoria()
		{
			var categoriaId = Convert.ToInt32(Request["cId"]);
			return View("SubCategoria/Index", categoriaId);
		}

		public ActionResult Campo()
		{
			var subcategoriaId = Convert.ToInt32(Request["cId"]);
			return View("Campo/Index", subcategoriaId);
		}
    }
}
