using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using FinalProjectA;

namespace FinalProjectT1
{
    public class FactoryFloor
    {
        IFloor FS;

        public IFloor GetFloor(string Floors)
        {
            if (Floors == "Floor 1") { FS = new Floor_1();}
            else if (Floors == "Floor 2"){ FS = new Floor_2(); }
            else if (Floors == "Floor 3"){FS = new Floor_3();}
            else if (Floors == "Floor 4") {FS = new Floor_4();}
            return FS;
            
        }
    }
}
