using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class Campo : Entity<Campo>
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public decimal Ordem { get; set; }
		public string Descricao { get; set; }
		public string Tipo { get; set; }
		public virtual SubCategoria SubCategoria { get; set; }

		public Campo() : base()
		{
		}
	}
}