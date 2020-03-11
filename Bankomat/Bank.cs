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

         public Tuple<int,int,double> GeneratAccount() {
            Random rand = new Random();
            double val=0;
            this.AccountNumber = rand.Next(1000000, 10000000);
            this.Pin = rand.Next(0, 10000);
            Console.WriteLine("Your Pin is:{0}", this.Pin);
            Console.WriteLine("Enter summ wich you want put on account\n");
            val = Convert.ToDouble(Console.ReadLine());
            this.User = new account(this.AccountNumber, this.Pin,val);
            Console.Clear();
            return Tuple.Create(this.AccountNumber,this.Pin,val);

        }
        public bool PinCorrect(int pin)
        {
            return this.User.Same_pin(pin);
        }
        public void Balaance_sync(double a)
        {
            this.User.Balaance_sync(a);
        }
    }
}
