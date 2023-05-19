using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Trucks;

namespace Завод
{
    public readonly struct overload
    {
        public static overload operator == (Truck truck1, Truck truck2)
        {
            if (truck1.max_weight==truck2.max_weight)
            {
                return true;
            }
        }
    }
}
