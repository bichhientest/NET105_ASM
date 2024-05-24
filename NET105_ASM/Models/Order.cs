using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NET105_ASM.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public int UserId { get; set; }


		[DataType(DataType.Date)]
		 public DateTime Orderdate { get; set; }

		public int Quatity { get; set; }

		public string TotalAmount { get; set; }

		public string Status { get; set; }
		[ForeignKey("UserId")]	
		public User User { get; set; }

		

	}
}
