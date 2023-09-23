using Microsoft.AspNetCore.Identity;

namespace shareWheel.DbConnection
{
	public class ApplicationUser:IdentityUser
	{
		
		public string? city { get; set; }
	}
}
