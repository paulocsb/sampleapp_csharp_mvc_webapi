using System;

namespace Domain.Contracts
{
	public interface IFormularioService<T> : IService<T> where T : class
	{
	}
}

