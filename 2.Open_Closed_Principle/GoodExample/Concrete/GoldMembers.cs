using _2.Open_Closed_Principle.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Open_Closed_Principle.GoodExample.Concrete
{
    public class GoldMembers : MemberShip
    {
        public override double TotalPayment(double ücret)
        {
            return ücret * 10;
        }
    }
}
