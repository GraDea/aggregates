using AntiPattern.Model;

namespace AntiPattern.Services
{
	public interface ILoyaltyService
	{
		void CalculateDiscount(Order order);
		void FillClientInfo(Order order);
	}
}