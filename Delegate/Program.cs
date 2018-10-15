using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Account account = new Account();
            // MessengeHandler handler = new MessengeHandler(new Messenger().SendMessage);
            account.ActionEvent += new Messenger().SendMessage;
            account.RegisterDelegate();
            account.Add(1000);            
            account.Withdraw(500);            
            Console.WriteLine(account.Sum);
            
        }
       
    }
}
