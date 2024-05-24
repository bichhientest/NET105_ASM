using System.ComponentModel.DataAnnotations.Schema;

namespace NET105_ASM.Models
{
	public class Fastfood
	{
		public int FastfoodId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Price { get; set; }

		public int ComboId { get; set; } // khóa ngoại combo
		[ForeignKey("Combo")]
		public ICollection <Combo> Combo { get; set; }
		
		
		

	}
}
