using BestCarDealership.Models;

namespace BestCarDealership.DL.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();

        Car GetCarById(int id);

        void AddCar(Car car);

        void RemoveCar(int id);

        List<Car> GetAllCarsByDealershipId(int dealershipId);

        List<Car> GetAllCarsByMake(string make);
    }

}
