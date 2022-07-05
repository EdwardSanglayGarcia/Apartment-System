using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace FinalProjectA
{
    public class Penthouse : IPricer
    {
        public double GivePrice()
        {
            return 45000;
        }


    }
}
