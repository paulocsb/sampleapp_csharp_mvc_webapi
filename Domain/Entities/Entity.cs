using Domain.Contracts;

namespace Domain.Entities
{
	public class Entity<T> : IEntity<T> where T : class
	{
		public Entity() : base()
		{
		}
	}
}

