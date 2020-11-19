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
			var fixture = new Fixture();

			var order = fixture.Create<Order>();
			
			return Task.FromResult(order);
		}
	}
}