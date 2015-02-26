using System;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
	public interface IService<T> : IEntity<T> where T : class
	{
		IEnumerable<T> Get();
		T GetById(int id);
		T Create(T entity);
		T Update(int id, T entity);
		bool Delete(int id);
	}
}

