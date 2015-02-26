using System;

namespace Domain.Contracts
{
	public interface ICategoriaService<T> : IService<T> where T : class
	{
	}
}

