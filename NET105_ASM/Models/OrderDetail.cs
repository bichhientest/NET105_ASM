using System.ComponentModel.DataAnnotations.Schema;

namespace NET105_ASM.Models
{
	public class OrderDetail
	{
		public int OrderDetailId { get; set; }
		public int OrderId { get; set; }
		public int FastfoodId { get; set; }
		 public int Quatity { get; set; }
		public string TotalAmount { get; set; }

		[ForeignKey("OrderId")]
		public Order Orders { get; set; }

		[ForeignKey("FastfoodId")]
		public Fastfood Fastfood { get; set; }
	}
}
