using System;
using Domain.Entities;
using Domain.Contracts;
using System.Linq;
using System.Collections.Generic;
using Domain.Data;

namespace Domain.Service
{
	public partial class FormularioService : IFormularioService<Formulario>
	{
		private ApplicationContext<Formulario> _applicationContext;

		public FormularioService(ApplicationContext<Formulario> applicationContext)
		{
			_applicationContext = applicationContext;
		}

		public IEnumerable<Formulario> Get()
		{
			return _applicationContext.Items.AsEnumerable();
		}

		public Formulario GetById(int id)
		{
			var entity = _applicationContext.Items.Where(p => p.Id == id).First();

			return entity;
		}

		public Formulario Create(Formulario entity)
		{
			_applicationContext.Items.Add(entity);
			_applicationContext.SaveChanges();

			return entity;
		}

		public Formulario Update(int id, Formulario entity)
		{
			var e = _applicationContext.Items.Where(p => p.Id == id).First();

			if (e != null)
			{
				e.Descricao = entity.Descricao;
				_applicationContext.SaveChanges();
			}

			return e;
		}

		public bool Delete(int id)
		{
			var entity = _applicationContext.Items.Remove(GetById(id));
			_applicationContext.Items.Remove(entity);

			if (_applicationContext.SaveChanges() > 0)
			{
				return true;
			}

			return false;
		}
	}
}

