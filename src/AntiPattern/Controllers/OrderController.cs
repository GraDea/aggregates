using System.Linq;
using System.Threading.Tasks;
using AntiPattern.Model;
using AntiPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace AntiPattern.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderService _orderService;
		private readonly ILoyaltyService _loyaltyService;

		public OrderController(IOrderService orderService, ILoyaltyService loyaltyService)
		{
			_orderService = orderService;
			_loyaltyService = loyaltyService;
		}

		// GET
		public async Task<IActionResult> Index(int id)
		{
			return Json(await _orderService.GetOrder(id));
		}

		public async Task<IActionResult> FirstProductName(int id)
		{
			var order = await _orderService.GetOrder(id);
			return Json(new {order.FirstProductName});
		}

		public async Task<IActionResult> ClientName(int id)
		{
			var order = await _orderService.GetOrder(id);
			_loyaltyService.FillClientInfo(order);

			return Json(new {order.Client.Name});
		}
	}
}