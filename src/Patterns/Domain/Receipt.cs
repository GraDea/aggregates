namespace Patterns.Domain
{
	public class Receipt
	{
		public decimal Price { get; }
		public decimal DiscountPrice { get; }

		public Receipt(decimal price, decimal discountPrice)
		{
			Price = price;
			DiscountPrice = discountPrice;
		}
	}
}