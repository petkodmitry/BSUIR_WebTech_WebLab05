using Microsoft.AspNetCore.Mvc;

namespace WebLab05.Components
{
	public class CartViewComponent : ViewComponent {
		public IViewComponentResult Invoke() {
			return View();
		}
	}
}
