using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov_Substitution__Principle.GoodExample.Abstract
{
    public abstract class Car
    {
        public int Id { get; set; }
        public string Start()
        {
            return "Araba çalıştı";
        }
    }
}
