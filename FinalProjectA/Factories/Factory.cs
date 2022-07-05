using FinalProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectT1
{
    public class Factory
    {
        IPricer IP;

        public IPricer Create(string choice)
        {
            if (choice == "1 Bedroom")
            {
                IP = new OneBedroom();
            }

            else if (choice == "2 Bedroom")
            {
                IP = new TwoBedroom();
            }

            else if (choice == "3 Bedroom")
            {
                IP = new ThreeBedroom();
            }

            else if (choice == "Studio")
            {
                IP = new Studio();
            }

            else if (choice == "Penthouse")
            {
                IP = new Penthouse();
            }

            else if (choice == "Suite")
            {
                IP = new Suite();
            }

            return IP;
        }

       
    }
}
