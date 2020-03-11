using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Client
    {
        private account info;
        public Client()
        {
            this.info = new account();
        }
        public void SetBankInfo(Tuple<int, int,double> a) {

            this.info.Set_account_info(a.Item1, a.Item2, a.Item3);
        }
        public double take_maney_from_acc() {
            double sum;
            Console.WriteLine("Enter sum of money wich you want take from account\n");
            sum = Convert.ToDouble(Console.ReadLine());
            this.info.takemoney_from_account(sum);
            return this.info.Balance_info();
        }
        public double put_maney_from_acc()
        {
            double sum;
            Console.WriteLine("Enter sum of money wich you want to put on account\n");
            sum = Convert.ToDouble(Console.ReadLine());
            this.info.put_money_account(sum);
            return this.info.Balance_info();
        }
        public double Get_balance_value() {
            return this.info.Balance_info();
        }
        public bool PinCorrect(int pin) {
            return this.info.Same_pin(pin);
        }

    }
}
