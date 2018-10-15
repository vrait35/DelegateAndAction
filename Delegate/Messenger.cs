using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Messenger : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
