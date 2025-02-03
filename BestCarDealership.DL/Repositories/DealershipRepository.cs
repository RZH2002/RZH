using BestCarDealership.DL.Interfaces;
using BestCarDealership.Models;
using CarDealership.DL.MemoryDb;

namespace BestCarDealership.DL.Repositories
{
    public class DealershipRepository : IDealershipRepository
    {
        public List<Dealership> GetAllDealerships()
        {
            return MemoryDb.DealershipData;
        }

        public Dealership GetDealershipById(int id)
        {
            return MemoryDb.DealershipData.FirstOrDefault(d => d.Id == id);
        }

        public void AddDealership(Dealership dealership)
        {
            MemoryDb.DealershipData.Add(dealership);
        }

        public void RemoveDealership(int id)
        {
            var dealershipToRemove = MemoryDb.DealershipData.FirstOrDefault(d => d.Id == id);
            if (dealershipToRemove != null)
            {
                MemoryDb.DealershipData.Remove(dealershipToRemove);
            }
        }

        public List<Car> GetDealershipInventory(int dealershipId)
        {
            return MemoryDb.DealershipData
                .FirstOrDefault(d => d.Id == dealershipId)?
                .Inventory ?? new List<Car>();
        }
    }
}
