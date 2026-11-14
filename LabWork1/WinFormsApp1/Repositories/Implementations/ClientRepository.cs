using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork1.Entities;
using LabWork1.Entities.Enums;
using LabWork1.Repositories;

namespace LabWork1.Repositories.Implementations
{
    internal class ClientRepository : IClientRepository
    {
        public void CreateClient(Client client) { }
        public void DeleteClient(int id) { }
        public Client ReadClientById(int id) => Client.CreateEntity(0, string.Empty, string.Empty, ClientType.None);
        public IEnumerable<Client> ReadClients() => new List<Client>();
        public void UpdateClient(Client client) { }
    }
}