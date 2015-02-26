﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class SubCategoria : Entity<SubCategoria>
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Descricao { get; set; }
		public string Slug { get; set; }
		public virtual Categoria Categoria { get; set; }

		public SubCategoria() : base()
		{
		}
	}
}