using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork1.Entities;

namespace LabWork1.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> ReadClients();
        Client ReadClientById(int id);
        void CreateClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(int id);
    }
}