using System;
using Domain.Entities;
using Domain.Contracts;
using System.Linq;
using System.Collections.Generic;
using Domain.Data;

namespace Domain.Service
{
	public partial class CategoriaService : ICategoriaService<Categoria>
	{
		private ApplicationContext<Categoria> _applicationContext;

		public CategoriaService(ApplicationContext<Categoria> applicationContext)
		{
			_applicationContext = applicationContext;
		}

		public IEnumerable<Categoria> Get()
		{
			return _applicationContext.Items.AsEnumerable();
		}

		public Categoria GetById(int id)
		{
			var entity = _applicationContext.Items.Where(p => p.Id == id).First();

			return entity;
		}

		public Categoria Create(Categoria entity)
		{
			_applicationContext.Items.Add(entity);
			_applicationContext.SaveChanges();

			return entity;
		}

		public Categoria Update(int id, Categoria entity)
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

