using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain.Entities
{
	public class Formulario : Entity<Formulario>
	{
		[Key]
		[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Descricao { get; set; }
		public List<Categoria> Categorias { get; set; }

		public Formulario() : base()
		{
		}
	}
}