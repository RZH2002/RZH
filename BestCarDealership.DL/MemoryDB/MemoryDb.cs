using BestCarDealership.Models;

namespace CarDealership.DL.MemoryDb
{
    public static class MemoryDb
    {
        public static List<Car> CarData = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                Make = "Toyota",
                Model = "Camry",
                Year = 2020,
                Price = 25000.00
            },
            new Car()
            {
                Id = 2,
                Make = "Honda",
                Model = "Civic",
                Year = 2018,
                Price = 20000.00
            },
            new Car()
            {
                Id = 3,
                Make = "Ford",
                Model = "Escape",
                Year = 2022,
                Price = 30000.00
            }
        };

        public static List<Dealership> DealershipData = new List<Dealership>()
        {
            new Dealership()
            {
                Id = 1,
                Name = "ABC Motors",
                Location = "123 Main St", 
                Inventory = new List<Car>
                {
                    MemoryDb.CarData[0]
                }
            },
            new Dealership()
            {
                Id = 2,
                Name = "XYZ Cars",
                Location = "456 Elm St",
                Inventory = new List<Car>
                {
                    MemoryDb.CarData[1]
                }
            },
            new Dealership()
            {
                Id = 3,
                Name = "123 Auto",
                Location = "789 Oak St",
                Inventory = new List<Car>
                {
                    MemoryDb.CarData[2]
                }
            }
        };
    }
}
