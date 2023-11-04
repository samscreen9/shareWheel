using Microsoft.AspNetCore.Identity;
using shareWheel.Migrations;

namespace shareWheel.DbConnection
{
	public class ApplicationUser:IdentityUser
	{
		public string firstname { get; set; }

		public string lastname { get; set; }

		public string? city { get; set; }
	}
}
