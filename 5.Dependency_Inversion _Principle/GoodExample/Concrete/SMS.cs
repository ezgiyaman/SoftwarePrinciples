using _5.Dependency_Inversion__Principle.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Dependency_Inversion__Principle.GoodExample.Concrete
{
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            MessageBox.Show("Yeni mesaj geldi");
        }
    }
}
