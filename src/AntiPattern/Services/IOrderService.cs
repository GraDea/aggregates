using System.Threading.Tasks;
using AntiPattern.Model;

namespace AntiPattern.Services
{
	public interface IOrderService
	{
		public Task<Order> GetOrder(int id);
	}
}