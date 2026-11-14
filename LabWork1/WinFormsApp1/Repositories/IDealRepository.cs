using LabWork1.Entities;

namespace LabWork1.Repositories
{
    public interface IDealRepository
    {
        IEnumerable<Deal> ReadDeals();
        Deal ReadDealById(int id); 
        void CreateDeal(Deal deal);
        void UpdateDeal(Deal deal); 
        void DeleteDeal(int id);   
    }
}