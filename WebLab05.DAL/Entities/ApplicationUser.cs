using Microsoft.AspNetCore.Identity;

namespace WebLab05.DAL.Entities
{
	public class ApplicationUser : IdentityUser {
		public byte[] AvatarImage { get; set; }
		public string ImageMimeType { get; set; }
	}
}
