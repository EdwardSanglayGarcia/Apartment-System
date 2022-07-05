using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace FinalProjectA
{
    public class ThreeBedroom : IPricer
    {
        public double GivePrice()
        {
            return 35000;
        }
   
   
    }
}
