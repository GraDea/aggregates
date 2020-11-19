using System.Threading.Tasks;
using AntiPattern.Model;
using AntiPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace AntiPattern.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderService _orderService;

		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		// GET
		public async Task<IActionResult> Index(int id)
		{
			return Json(await _orderService.GetOrder(id));
		}
	}
}