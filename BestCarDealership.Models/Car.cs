using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestCarDealership.Models
{
    public class Car : BaseClass
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car()
        {
            
        }

        public Car(int id, string make, string model, int year, double price) : base(id)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} - ${Price:N2}";
        }
    }

}
