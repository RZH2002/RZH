namespace BestCarDealership.Models.Request
{
    public class GetCarsByDealershipResponse
    {
        public Dealership? Dealership { get; set; }

        public List<Car>? Cars { get; set; }
    }
}
