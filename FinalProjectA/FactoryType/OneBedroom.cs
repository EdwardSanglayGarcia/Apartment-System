using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace FinalProjectA
{
    public class OneBedroom : IPricer
    {
        public double GivePrice()
        {
            return 15000;
        }
   
     
    }
}
