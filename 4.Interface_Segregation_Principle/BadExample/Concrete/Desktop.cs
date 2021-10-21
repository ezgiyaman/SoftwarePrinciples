using _4.Interface_Segregation_Principle.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface_Segregation_Principle.BadExample.Concrete
{
    public class Desktop : IComputer
    {
        public string Carry()
        {
            return "Bütün masaüstü bilgisayarlar taşınamaz.";
        }

        public string ConnectInternet()
        {
            return "Bütün masaüstü bilgisayarlar internete bağlanabilir.";
        }
    }
}
