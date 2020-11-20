using System;
using System.Threading.Tasks;
using AntiPattern.Model;
using AutoFixture;

namespace AntiPattern.Services
{
	public class OrderService : IOrderService
	{
		public Task<Order> GetOrder(int id)
		{
			var order = GetOrderFromRepository(id);

			return Task.FromResult(order);
		}

		private Order GetOrderFromRepository(int id)
		{
			var fixture = new Fixture();
			fixture.Customizations.Add(
				new ElementsBuilder<DepartmentProduct>(
					new DepartmentProduct {Name = "Pepperoni"},
					new DepartmentProduct {Name = "SuperMeat"},
					new DepartmentProduct {Name = "Arriva"}));

			fixture.Customizations.Add(
				new ElementsBuilder<Client>(
					new Client {Id = (id % 4) + 1}
				));

			var order = fixture.Create<Order>();
			return order;
		}
	}
}