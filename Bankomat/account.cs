using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class account
    {
        private int AccountNumber;
        private int Pin;
        private double Balance;
        public account(int AccNumb, int Pin,double Bal) {
            this.AccountNumber = AccNumb;
            this.Pin = Pin;
            this.Balance = Bal;
        }
         public void minus(double val) {
            if (this.Balance - val < 0) {
                Console.WriteLine("Not such summ in balance\n");
            }
            else {
                this.Balance -= val;
                Console.WriteLine("");
            }
        }
    }
}
