using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace Patterns.Domain
{
	public class Order
	{
		private  List<OrderLine> _composition;

		public void AddProduct(Product product, Price price)
		{
			_composition.Add(new OrderLine(product, price));
		}

		public Receipt GetReceipt()
		{
			return new Receipt(_composition.Sum(x=>x.Price.Value),
				_composition.Sum(x=>x.DiscountPrice.Value));
		}

		public OrderLine GetFirstLine()
		{
			return _composition.First();
		}
		
		
	}
}