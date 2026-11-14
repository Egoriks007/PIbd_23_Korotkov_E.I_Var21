using LabWork1.Entities;
using LabWork1.Repositories;

namespace LabWork1.Repositories.Implementations
{
    internal class ProvidedServiceRepository : IProvidedServiceRepository
    {
        public void CreateProvidedService(ProvidedService providedService) { }
        public void DeleteProvidedService(int id) { }
        public IEnumerable<ProvidedService> ReadProvidedServices() => new List<ProvidedService>();
        public void UpdateProvidedService(ProvidedService providedService) { }

        // Возвращаем пустую связку для заглушки
        public ProvidedService ReadProvidedServiceById(int id) => ProvidedService.CreateElement(0, 0, 0, 0);
    }
}