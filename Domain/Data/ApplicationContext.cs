using System;
using System.Data.Entity;

namespace Domain.Data
{
	public class ApplicationContext<T> : DbContext where T : class
	{
		public DbSet<T> Items { get; set; }

		public ApplicationContext() : base("name=DefaultContext")
		{
		}
	}
}

