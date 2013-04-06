using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngMvcShop.Models;

namespace AngMvcShop.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult GetProductsPage(int offset, int count)
		{
			var products = Enumerable.Range(offset + 1, count)
			                         .Select(x => new Product
				                         {
					                         Number = x,
					                         Name = "Produkt " + x,
					                         Description =
						                         "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec fermentum suscipit est et vehicula. Pellentesque nisl urna, adipiscing ut auctor ut, sagittis in odio. Integer fermentum volutpat tellus vel molestie. Donec vulputate venenatis mauris, vitae vulputate libero mattis ut. Integer volutpat ultrices lorem vitae facilisis. Fusce euismod sollicitudin porttitor. Duis ullamcorper mauris nec magna consequat tincidunt. Mauris accumsan euismod nisi, ut iaculis enim sagittis a.\r\nDuis tempor molestie turpis ut convallis. Cras tincidunt, leo eget tristique sodales, lectus libero auctor risus, in cursus lectus nunc nec nunc. Nam vel est felis, nec convallis ante. Maecenas auctor tempor dui non fringilla. In ut odio urna, id aliquam quam. Duis eu diam urna. In hac habitasse platea dictumst. Suspendisse condimentum congue orci. Fusce eu massa quis erat egestas placerat ac vitae enim.",
					                         ThumbnailUrl = "http://placehold.it/50x50&text=" + x,
					                         ImageUrl = "http://placehold.it/250x500&text=Produkt+" + x,
				                         });
			return new JsonResult{JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = products};
		}
	}
}
