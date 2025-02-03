using BestCarDealership.Models;

namespace BestCarDealership.DL.Interfaces
{
    public interface IDealershipRepository
    {
        List<Dealership> GetAllDealerships();

        Dealership GetDealershipById(int id);

        void AddDealership(Dealership dealership);

        void RemoveDealership(int id);

        List<Car> GetDealershipInventory(int dealershipId);
    }
}
