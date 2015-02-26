using System;
using Domain.Entities;
using Domain.Contracts;
using System.Linq;
using System.Collections.Generic;
using Domain.Data;

namespace Domain.Service
{
	public partial class CampoService : ICampoService<Campo>
	{
		private ApplicationContext<Campo> _applicationContext;

		public CampoService(ApplicationContext<Campo> applicationContext)
		{
			_applicationContext = applicationContext;
		}

		public IEnumerable<Campo> Get()
		{
			return _applicationContext.Items.AsEnumerable();
		}

		public Campo GetById(int id)
		{
			var entity = _applicationContext.Items.Where(p => p.Id == id).First();

			return entity;
		}

		public Campo Create(Campo entity)
		{
			_applicationContext.Items.Add(entity);
			_applicationContext.SaveChanges();

			return entity;
		}

		public Campo Update(int id, Campo entity)
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

