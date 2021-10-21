using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov_Substitution__Principle.BadExample
{
    public abstract class Cars
    {
        public int Id { get; set; }
        public string Start()
        {
            return "Araba çalıştı";
        }
        public abstract string AirCondioning();
    }
}
