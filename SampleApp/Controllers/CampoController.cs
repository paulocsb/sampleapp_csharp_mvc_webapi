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
    public class CampoController : Controller
    {
		ICampoService<Campo> _service;

		public CampoController() 
			: this(new CampoService(new ApplicationContext<Campo>()))
		{
		}

		public CampoController(ICampoService<Campo> service)
		{
			_service = service;
		}

		public ActionResult Index()
		{
			var campos = _service.Get();

			return View(campos);
		}
    }
}
