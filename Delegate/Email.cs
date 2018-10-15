using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Email : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email: "+message);
        }
    }
}
