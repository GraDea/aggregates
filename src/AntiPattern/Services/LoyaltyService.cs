using AntiPattern.Model;

namespace AntiPattern.Services
{
	class LoyaltyService : ILoyaltyService
	{
		private readonly IClientService _clientService;

		public LoyaltyService(IClientService clientService)
		{
			_clientService = clientService;
		}

		public void CalculateDiscount(Order order)
		{
			FillClientInfo(order);

			FillDiscountPrices(order);
		}

		private static void FillDiscountPrices(Order order)
		{
			foreach (var orderLine in order.Composition)
			{
				orderLine.DiscountPrice = new Price
					{Value = orderLine.Price.Value * (100 - order.Client.Discount) / 100};
			}
		}

		public void FillClientInfo(Order order)
		{
			var client = _clientService.GetClient(order.Client.Id);
			order.Client = client;
		}
	}
}