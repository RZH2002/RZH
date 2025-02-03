using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCarDealership.Models
{
    public class Dealership : BaseClass
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public List<Car> Inventory { get; set; }

        public Dealership()
        {
            
        }

        public Dealership(int id, string name) : base(id)
        {
            Name = name;
            Inventory = new List<Car>();
        }

        public Dealership(int id, string name, string location, List<Car> inventory) : this(id, name)
        {
            Location = location;
        }

        public void AddCar(Car car)
        {
            Inventory.Add(car);
        }
    }
}
