namespace Patterns.Domain
{
	public class ClientService
	{
		public Client GetById(int id)
		{
			return new Client(id);
		}
	}
}