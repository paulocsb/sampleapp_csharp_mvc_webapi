using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class Categoria : Entity<Categoria>
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Descricao { get; set; }
		public string Slug { get; set; }
		public virtual Formulario Formulario { get; set; }

		public Categoria() : base()
		{
		}
	}
}