using System.Collections.Generic;

namespace Patterns.Domain
{
	public class Client
	{
		private readonly int _id;

		public Client(int id)
		{
			_id = id;
		}

		public Order CreateOrder()
		{
			return new Order();
		}

		public List<Order> Orders { get; set; }
	}
}