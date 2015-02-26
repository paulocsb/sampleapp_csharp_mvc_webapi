using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using Domain.Data;
using Domain.Contracts;
using Domain.Service;

namespace SampleApp.Controllers
{
    public class SubCategoriaController : Controller
    {
		ISubCategoriaService<SubCategoria> _service;

		public SubCategoriaController() 
			: this(new SubCategoriaService(new ApplicationContext<SubCategoria>()))
		{
		}

		public SubCategoriaController(ISubCategoriaService<SubCategoria> service)
		{
			_service = service;
		}

		public ActionResult Index()
		{
			var subcategorias = _service.Get();

			return View(subcategorias);
		}
    }
}
