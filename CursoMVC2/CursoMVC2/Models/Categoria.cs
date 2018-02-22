using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC2.Models
{
	public class Categoria
	{
		public int CategoriaId { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Ingrese un nombre con minimo 3 y maximo 50 letras")]
		public string Nombre { get; set; }

		[StringLength(250)]
		[DisplayName("Descripcion")]
		public string Descripcion { get; set; }

		public bool Estado { get; set; }

    }
}
