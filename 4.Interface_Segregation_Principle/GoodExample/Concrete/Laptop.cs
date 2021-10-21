using _4.Interface_Segregation_Principle.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface_Segregation_Principle.GoodExample.Concrete
{
    public class Laptop : ICarry , IConnectInternet
    {
        public string Carry() => "Bütün Laptoplar taşınabilir.";
        public string CoonectInternet() => "Bütün Laptoplar internete bağlanabilir.";


    }
}
