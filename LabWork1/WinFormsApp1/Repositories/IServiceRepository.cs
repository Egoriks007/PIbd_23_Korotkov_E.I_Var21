using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork1.Entities;

namespace LabWork1.Repositories
{
    public interface IServiceRepository
    {
        IEnumerable<Service> ReadServices();
        Service ReadServiceById(int id);
        void CreateService(Service service);
        void UpdateService(Service service);
        void DeleteService(int id);
    }
}
