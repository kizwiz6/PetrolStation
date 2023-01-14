using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KizwizPetrol
{
    /// <summary>
    /// Interface Segregation Principle
    /// </summary>
    public interface IVehicleService
    {
        void Refuel(double fuelAmount);
        void Wash();
    }
}
