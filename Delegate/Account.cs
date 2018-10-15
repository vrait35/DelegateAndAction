using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void MessengeHandler(string message);
    public class Account
    {
       // private MessengeHandler handler;
        public event MessengeHandler ActionEvent;
       // public void RegisterDelegate(MessengeHandler handler)
       // {
       //     this.handler += handler;
       // }
       // public void UnRegisterDelegate(MessengeHandler handler)
       // {
       //     this.handler -= handler;
       // }

        public int Sum { get; private set; }
       
        
        public void  Add(int sum)
        {
           
            Sum += sum;
            ActionEvent?.Invoke("вы добавили свой счет: " + sum);
        }
        public void Withdraw(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                ActionEvent?.Invoke("вы сняли бабки");
            }
            else
            {
                ActionEvent?.Invoke("недостаточно средств");
            }
        }      
    }
}
