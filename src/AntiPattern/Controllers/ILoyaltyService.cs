using System.Collections.Generic;
using System.Threading.Tasks;
using AntiPattern.Model;
using AutoFixture;

namespace AntiPattern.Controllers
{
	public interface ILoyaltyService
	{
		void CalculateDiscount(Order order);
		void FillClientInfo(Order order);
	}

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
		}

		public void FillClientInfo(Order order)
		{
			var client = _clientService.GetClient(order.Client.Id);
			order.Client = client;
		}
	}

	public interface IClientService
	{
		Client GetClient(int clientId);
	}

	class ClientService : IClientService
	{
		public Client GetClient(int clientId)
		{
			var fixture = new Fixture();

			return fixture
				.Build<Client>()
				.With(x => x.Id, clientId)
				.With(x=>x.Name, GetName(clientId))
				.Create();
		}

		private string GetName(int clientId)
		{
			var names = new Dictionary<int, string> { {1, "Mike"}, {2, "Jane"}, {3, "Elena"}, {4, "Nick"}};

			return names[clientId];
		}
	}
}