using System.ComponentModel.DataAnnotations;

namespace shareWheel.Models
{
	public class RegisterModel
	{

		[EmailAddress]
		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[Phone]
		[Required(ErrorMessage = "Phone is required")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Phone is required")]
		public string firstname { get; set; }

		[Required(ErrorMessage = "Phone is required")]
		public string lastname { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }

		[Compare(nameof(Password),ErrorMessage ="password not matched")]
		public string ConfirmPassword { get; set; }
	}
}
