﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Interface_Segregation_Principle.BadExample.Interface
{
    public interface IComputer
    {
        string ConnectInternet();

        string Carry();
    }
}
