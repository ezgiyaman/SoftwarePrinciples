using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Dependency_Inversion__Principle.BadExample
{
    public class Notification
    {
        private SMS _sms;
        private Whatsapp _whatsapp;
        public Notification()
        { 
            _sms = new SMS();
            _whatsapp = new Whatsapp();
        }

        public void Send()
        {
            _sms.SendSMS();
            _whatsapp.SendWhatsappMessage();
        }
    }

}
