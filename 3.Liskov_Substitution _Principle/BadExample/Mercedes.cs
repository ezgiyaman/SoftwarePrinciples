using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov_Substitution__Principle.BadExample
{
    public class Mercedes : Cars
    {
        public override string AirCondioning() => "Mercedes'in kliması çalıştı";
       
    }
}
