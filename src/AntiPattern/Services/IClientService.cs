using AntiPattern.Model;

namespace AntiPattern.Services
{
	public interface IClientService
	{
		Client GetClient(int clientId);
	}
}