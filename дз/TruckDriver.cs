using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person;

namespace Driver
{
    class TruckDriver : OfficePerson
    {
        public TruckDriver(string firstName, string lastName, int driversLicense) : base(firstName, lastName)
        {
            DriversLicense = driversLicense;
        }
        public int DriversLicense { get; }  
        public void GetFullName()
        {
            Console.WriteLine($"|Nme: {FirstName}| Last name: {LastName}| Driver's license {DriversLicense}|");
        }
    }
}
