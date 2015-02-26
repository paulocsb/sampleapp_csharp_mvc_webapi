using System;

namespace Domain.Contracts
{
	public interface ICampoService<T> : IService<T> where T : class
	{
	}
}

