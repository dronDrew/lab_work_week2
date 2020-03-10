using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Bank
    {
        private int AccountNumber;
        private int Pin;
        private account User;
         public Tuple<int,int> GeneratAccount() {
            Random rand = new Random();
            double val=0;
            this.AccountNumber = rand.Next(1000000, 10000000);
            this.Pin = rand.Next(0, 10000);
            Console.WriteLine("Enter summ wich you want put on account\n");
            val = Convert.ToDouble(Console.ReadLine());
            this.User = new account(this.AccountNumber, this.Pin,val);
            return Tuple.Create(this.AccountNumber,this.Pin);
        }
        
    }
}
