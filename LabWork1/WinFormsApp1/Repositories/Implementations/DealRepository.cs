using LabWork1.Entities;
using LabWork1.Repositories;

namespace LabWork1.Repositories.Implementations
{
    internal class DealRepository : IDealRepository
    {
        public void CreateDeal(Deal deal) { }
        public void DeleteDeal(int id) { }
        public IEnumerable<Deal> ReadDeals() => new List<Deal>();
        public void UpdateDeal(Deal deal) { }

        // Передаем 4 аргумента (0, 0, 0, 0)
        public Deal ReadDealById(int id) => Deal.CreateOperation(0, 0, 0, 0);
    }
}