using _5.Dependency_Inversion__Principle.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Dependency_Inversion__Principle.GoodExample.Concrete
{
    public class Notification
    {
        private ICollection<IMessage> _messages;

        public Notification(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
}
