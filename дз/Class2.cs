using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Trucks;


namespace System.Info
{
    static class Information
    {
       public static void GetInfo()
        {
            Random number = new Random();
            Console.WriteLine($"Truck number: {number.Next(4985, 9980)}");
            Console.WriteLine($"Invoice number: {number.Next(1, 100)}");
            Console.WriteLine($"Cargo weight: {number.Next(105, 136)}");
        }
    }
}
