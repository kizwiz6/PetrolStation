using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KizwizPetrol
{
    /// <summary>
    /// Open-Closed Principle
    /// </summary>
    public interface IPaymentMethod
    {
        void Pay(double amount);
    }
}
