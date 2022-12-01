using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEFCore.Models
{
	
	public class Country
	{
		
		public int PId { get; set; }
	
		public string Name { get; set; }

		public DateTime AddedOn { get; set; }

		public int Population { get; set; }
	}
}
