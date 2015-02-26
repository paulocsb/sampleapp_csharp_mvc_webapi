using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Data;
using Domain.Contracts;
using Domain.Service;
using System.Web.Http;

namespace SampleApp.Controllers
{
	public class CategoriaController : ApiController
	{
		ICategoriaService<Categoria> _service;

		public CategoriaController()
			: this(new CategoriaService(new ApplicationContext<Categoria>()))
		{
		}

		public CategoriaController(ICategoriaService<Categoria> service)
		{
			_service = service;
		}

		// GET: api/values
		[HttpGet]
		public IEnumerable<Categoria> Get()
		{
			return _service.Get();
		}
	}
}
