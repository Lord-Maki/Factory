using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    interface  IOfficePerson
    {
        string FirstName { get; }
        string LastName { get; }
        void GetFulName();
    }

    class OfficePerson : IOfficePerson
    {
        public OfficePerson (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

       public string FirstName { get; }
       public string LastName { get; }
       public void GetFulName()
        {
            Console.WriteLine($"|Nme: {FirstName}| Last name: {LastName}|");
        }
    }
}
