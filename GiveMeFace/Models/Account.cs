using System;
namespace GiveMeFace.Models
{
	public class Account
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Product { get; set; }
		public string Link { get; set; }

		public Account(string first, string last, string email)
		{
			this.FirstName = first;
			this.LastName = last;
			this.Email = email;
		}
	}
}

