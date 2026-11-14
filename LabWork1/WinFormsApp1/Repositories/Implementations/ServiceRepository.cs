using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork1.Entities;
using LabWork1.Repositories;

namespace LabWork1.Repositories.Implementations
{
    internal class ServiceRepository : IServiceRepository
    {
        public void CreateService(Service service) { }
        public void DeleteService(int id) { }

        public Service ReadServiceById(int id) =>
            Service.CreateEntity(0, string.Empty, 0);

        public IEnumerable<Service> ReadServices() => new List<Service>();

        public void UpdateService(Service service) { }
    }
}
