using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concecionaria.Entity
{
	public class Ventas
	{
		[Key]
		public int idVentas { get; set; }
		public string? importe { get; set; }
		public int descuento { get; set; }
		public DateTime fecha { get; set; }

		[ForeignKey("Vehiculo")]
		public int idVehiculo { get; set; }
		public Vehiculo? vehiculo { get; set; }

		[ForeignKey("Cliente")]
		public int idCliente { get; set; }
		public Cliente? Cliente { get; set; }



	}
}
