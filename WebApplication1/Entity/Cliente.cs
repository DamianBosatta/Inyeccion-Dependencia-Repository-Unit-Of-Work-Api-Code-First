using System.ComponentModel.DataAnnotations;

namespace Concecionaria.Entity
{
	public class Cliente
	{
	    [Key]
		public int idCliente { get; set; }
		public string? nombre { get; set; }
		public int dni { get; set; }
		public string? direccion { get; set; }
		


	}
}
