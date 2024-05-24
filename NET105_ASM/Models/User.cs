using System.ComponentModel.DataAnnotations;
namespace NET105_ASM.Models
{
	public class User
	{
		public  int UserId { get; set; }

		[Required(ErrorMessage ="Please enter Username.")]
		public string Username { get; set; }


		[Required(ErrorMessage = "Please enter Email address.")]
		[EmailAddress]
		public string UserEmail { get; set; }

		[Required(ErrorMessage = "Please enter Password.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

	}
}
