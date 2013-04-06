using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngMvcShop.Models
{
	public class Product
	{
		public long Number { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ThumbnailUrl { get; set; }
		public string ImageUrl { get; set; }
	}
}