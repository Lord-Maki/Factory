using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Material;
using System.Info;
using System.ComponentModel.DataAnnotations;

namespace System.Trucks
{
 
     class Truck
    {
        private bool TrucksRelouded;
        public readonly int max_weight;
        public Truck(int value) 
        {
            max_weight = value;
        }  
        public void TruckCondition()
        {
            if (TrucksRelouded == true)
            {
                Console.WriteLine("The truck relouded...");
                Information.GetInfo();
                Console.WriteLine("Forwrd to the road-object");
                TrucksRelouded = false;
            }
            else
            {
                Console.WriteLine("Forwrd to download");
                Download();
            }
        }
        public void Download()
        {
            Console.WriteLine(max_weight);
           var rnd = new Random();
            Materials material = (Materials)rnd.Next(1,4);
            Console.WriteLine($"The truck is loading {material}...");
            TrucksRelouded=true;
            TruckCondition();
        }
    }

}
