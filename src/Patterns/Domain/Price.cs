namespace Patterns.Domain
{
	public readonly struct Price
	{
		public Price(decimal value)
		{
			Value = value;
		}

		public decimal Value { get; }
	}
}