using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

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
		public List<Campo> Campos { get; set; }

		public SubCategoria() : base()
		{
		}
	}
}