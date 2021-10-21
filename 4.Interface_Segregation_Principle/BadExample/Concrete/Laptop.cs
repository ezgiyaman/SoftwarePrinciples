using _4.Interface_Segregation_Principle.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface_Segregation_Principle.BadExample.Concrete
{
    public class Laptop : IComputer
    {
        public string Carry()
        {
            return "Bütün Laptoplar taşınabilir.";
        }

        public string ConnectInternet()
        {
            return "Bütün Laptoplar internete bağlanabilir.";
        }
    }
    }
}
