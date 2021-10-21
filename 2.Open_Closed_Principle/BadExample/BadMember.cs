using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Open_Closed_Principle.BadExample
{
    public enum MemberType
    {
        Premium, Standard, Gold
    }
    public  class BadMember
    {
        public double TotalPayment(double ücret, MemberType memberType)
        {
            double totalpayment = 0;
            if (memberType == MemberType.Premium)
            {
                totalpayment += ücret * 7;

            }
            else if (memberType == MemberType.Standard)
            {
                totalpayment += ücret * 5;

            }
            else if (memberType == MemberType.Gold)
            {
                totalpayment += ücret * 10;
            }
            return totalpayment;
        }
    }
}
