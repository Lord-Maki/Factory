using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Trucks;
using System.Material;
using Person;
using Driver;


class Program
 {
    static void Main()
    {
        Truck truck = new Truck(150);
        truck.TruckCondition();
        OfficePerson Ofperson = new OfficePerson(firstName: "Lili", lastName: "Prcker") ;
        Ofperson.GetFulName();
        TruckDriver driver = new TruckDriver(firstName: "Ric", lastName: "Hamanson", driversLicense: 547866);
        driver.GetFullName();

        Truck truck2 = new Truck(155);

    }

 }
