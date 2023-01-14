using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KizwizPetrol
{
    /// <summary>
    /// Dependency Inversion Principle by depending on abstractions (interfaces) rather than concretions (implementations).
    /// </summary>
    public class PetrolStation
    {
        private List<IVehicleService> _services;
        private FuelService _fuelService;

        public PetrolStation(FuelService fuelService, List<IVehicleService>services)
        {
            _fuelService = fuelService;
            _services = services;
        }

        public void Refuel(Vehicle vehicle)
        {
            _fuelService.Refuel(vehicle);
        }

        public void Service(Vehicle vehicle)
        {
            foreach (var service in _services)
            {
                service.Refuel(vehicle.FuelAmount);
                service.Wash();
            }
        }

        public void ProcessPayment(IPaymentMethod paymentMethod, double amount)
        {
            paymentMethod.Pay(amount);
        }
    }
}
