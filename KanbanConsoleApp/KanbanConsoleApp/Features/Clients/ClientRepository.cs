using System.Collections.Generic;

namespace KanbanConsoleApp.Features.Clients
{
    public class ClientRepository
    {
        private readonly List<Client> _clients = new List<Client>();

        public void SaveClient(Client client)
        {
            _clients.Add(client);
        }

        public List<Client> GetClients()
        {
            var clientsToReturn = new List<Client>();

            foreach (var client in _clients)
            {
                clientsToReturn.Add(new Client
                {
                    Name = client.Name
                });
            }
            clientsToReturn.Sort((x, y) => x.Name.CompareTo(y.Name));

            return clientsToReturn;
        }
    }
}
