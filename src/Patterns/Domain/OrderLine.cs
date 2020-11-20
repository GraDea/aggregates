namespace Patterns.Domain
{
	public class OrderLine
	{
		private readonly Product _product;
		private readonly Price _price;

		public OrderLine(Product product, Price price)
		{
			_product = product;
			_price = price;
		}

		public Price Price { get; set; }
		public Price DiscountPrice { get; set; }
	}
}