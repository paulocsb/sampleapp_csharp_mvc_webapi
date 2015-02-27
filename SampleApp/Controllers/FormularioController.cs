using System;
using System.Collections.Generic;
using Domain.Service;
using Domain.Contracts;
using Domain.Entities;
using Domain.Data;
using System.Net.Http;
using System.Web.Http; 

namespace SampleApp.Controllers
{
    public class FormularioController : ApiController
    {
		IFormularioService<Formulario> _service;

		public FormularioController() 
			: this(new FormularioService(new ApplicationContext<Formulario>()))
		{
		}

		public FormularioController(IFormularioService<Formulario> service)
		{
			_service = service;
		}

		// GET: api/values
		[HttpGet]
		public IEnumerable<Formulario> Get()
		{
			return _service.Get();
		}

		// GET api/values/5
		[HttpGet]
		public Formulario Get(int id)
		{
			return _service.GetById(id);
		}

		// POST api/values
		[HttpPost]
		public Formulario Post(Formulario item)
		{
			return _service.Create(item);
		}

		// PUT api/values/5
		[HttpPut]
		public Formulario Put(int id, Formulario item)
		{
			return _service.Update(id, item);
		}

		// DELETE api/values/5
		[HttpDelete]
		public bool Delete(int id)
		{
			return _service.Delete(id);
		}
    }
}
