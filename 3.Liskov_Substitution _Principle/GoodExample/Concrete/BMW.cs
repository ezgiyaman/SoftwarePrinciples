using _3.Liskov_Substitution__Principle.GoodExample.Abstract;
using _3.Liskov_Substitution__Principle.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov_Substitution__Principle.GoodExample.Concrete
{
    public class BMW : Car, IAirCondioning
    {
        public string Klima()
        {
            return "BMW'nin kliması çalıştı";
        }
    }
}
