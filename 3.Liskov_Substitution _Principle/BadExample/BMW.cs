﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov_Substitution__Principle.BadExample
{
    public class BMW : Cars
    {
        public override string AirCondioning()
        {
            throw new NotImplementedException();
        }
    }
}
