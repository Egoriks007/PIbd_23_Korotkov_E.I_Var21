using LabWork1.Entities;

namespace LabWork1.Repositories
{
    public interface IProvidedServiceRepository
    {
        IEnumerable<ProvidedService> ReadProvidedServices();
        ProvidedService ReadProvidedServiceById(int id);
        void CreateProvidedService(ProvidedService providedService);
        void UpdateProvidedService(ProvidedService providedService);
        void DeleteProvidedService(int id);
    }
}