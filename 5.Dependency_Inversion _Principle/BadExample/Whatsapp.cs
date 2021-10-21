using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Dependency_Inversion__Principle.BadExample
{
    public class Whatsapp
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public char Emoji { get; set; }
        public void SendWhatsappMessage()
        {
            //Send Message
        }
    }
}
