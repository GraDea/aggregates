using System.Collections.Generic;
using AntiPattern.Model;
using AutoFixture;

namespace AntiPattern.Services
{
	class ClientService : IClientService
	{
		public Client GetClient(int clientId)
		{
			var fixture = new Fixture();

			return fixture
				.Build<Client>()
				.With(x => x.Id, clientId)
				.With(x=>x.Name, GetName(clientId))
				.With(x=>x.Discount, fixture.Create<int>() % 15 + 5)
				.Create();
		}

		private string GetName(int clientId)
		{
			var names = new Dictionary<int, string> { {1, "Mike"}, {2, "Jane"}, {3, "Elena"}, {4, "Nick"}};

			return names[clientId];
		}
	}
}