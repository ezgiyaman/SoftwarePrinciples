using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Single_Responsibility_Principle.BadExample
{
   public class BadShopping
    {
        public int Id { get; set; }

        public String ProductName { get; set; }
        public double ProductPrice { get; set; }

        public bool LimitYeterliMi()
        {
            return true;
        }

        public bool AlisVerisiTamamla()
        {
            return true;
        }
    }
}
