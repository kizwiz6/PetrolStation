using KizwizPetrol;

internal class Program
{
    private static void Main(string[] args)
    {
        var fuelService = new FuelService();
        var carService = new CarService();
        var bikeService = new BikeService();

        var services = new List<IVehicleService> { carService, bikeService };
        var petrolStation = new PetrolStation(fuelService, services);

        var car = new Car { FuelCapacity = 40, FuelAmount = 20 };
        var bike = new Bike { FuelCapacity = 15, FuelAmount = 10 };

        petrolStation.Refuel(car);
        petrolStation.Service(car);
        petrolStation.ProcessPayment(new CreditCardPayment(), 100);
    }
}