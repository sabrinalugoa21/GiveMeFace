using System;
namespace GiveMeFace.Models
{
	public class Products
	{
        public string Product { get; set; }
		public string Company { get; set; }
		public int Id { get; set;  }

        public Products(string product, string company)
		{
			this.Product = product;
			this.Company = company;
		}

		public Products()
		{
		}
	}
}

