using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEFCore.Models
{
	
	public class City
	{
		
		public int Id { get; set; }

		
		public string Name { get; set; }

	
		

		
		public Country Country { get; set; }
	}
}

