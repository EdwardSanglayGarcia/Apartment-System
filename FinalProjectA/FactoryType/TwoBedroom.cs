using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace FinalProjectA
{
    public class TwoBedroom : IPricer
    {
        public double GivePrice()
        {
            return 25000;
        }
    
    }
}
