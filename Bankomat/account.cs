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
        public account() {
            this.Balance = 0;
            this.AccountNumber = 0;
            this.Pin = 0;
        
        }
        public account(int AccNumb, int Pin,double Bal) {
            this.AccountNumber = AccNumb;
            this.Pin = Pin;
            this.Balance = Bal;
        }
         public void takemoney_from_account(double val) {
            if (this.Balance - val < 0) {
                Console.WriteLine("Not such summ in balance\n");
            }
            else {
                this.Balance -= val;
                Console.WriteLine("");
            }
        }
        public void put_money_account(double val)
        {
           
                this.Balance += val;
                Console.WriteLine("");
            
        }
        public double Balance_info() {
            return this.Balance;
        }
        public void Set_account_info(int AccNumb, int Pin, double Bal) {
            this.AccountNumber = AccNumb;
            this.Pin = Pin;
            this.Balance = Bal;

        }
        public void Balaance_sync(double a) {
            this.Balance = a;
        }
        public bool Same_pin(int pin)
        {
            return pin==this.Pin;
        }
    }
}
