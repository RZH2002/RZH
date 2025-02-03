using BestCarDealership.DL.Interfaces;
using BestCarDealership.Models;
using CarDealership.DL.MemoryDb;

namespace BestCarDealership.DL
{
    public class CarRepository : ICarRepository
    {
        public List<Car> GetAllCars()
        {
            return MemoryDb.CarData;
        }

        public Car GetCarById(int id)
        {
            return MemoryDb.CarData.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(Car car)
        {
            MemoryDb.CarData.Add(car);
        }

        public void RemoveCar(int id)
        {
            var carToRemove = MemoryDb.CarData.FirstOrDefault(c => c.Id == id);
            if (carToRemove != null)
            {
                MemoryDb.CarData.Remove(carToRemove);
            }
        }

        public List<Car> GetAllCarsByDealershipId(int dealershipId)
        {
            return MemoryDb.DealershipData
                .FirstOrDefault(d => d.Id == dealershipId)?
                .Inventory ?? new List<Car>();
        }

        public List<Car> GetAllCarsByMake(string make)
        {
            return MemoryDb.CarData
                                   .Where(c => c.Make == make)
                                   .ToList();
        }
    }
}
