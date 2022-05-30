using System.ComponentModel.DataAnnotations;

namespace Concecionaria.Entity
{
	public class Vehiculo
	{   [Key]
		public int idVehiculo{get; set;}
		public string? marca{get; set;}
		public string? modelo{get; set;}
		public float precio{get; set;}
		public DateTime fechaBaja{get; set;}

			




	}
}
