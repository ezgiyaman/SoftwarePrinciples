using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Principle.BadExample
{
    public class Cart
    {
        public int GetUserCredit()
        {
            var userCredit = 25;

            return userCredit + 1000;
        }
    }
}
