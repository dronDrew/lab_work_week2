using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static public void Menu_General(ref Bank bank,ref Client client) {
            int choice = 0;
            Console.WriteLine("Press 1 to see balance on screen");
            Console.WriteLine("Press 2 to put  money in account ");
            Console.WriteLine("Press 3 to take  money from account ");
            Console.WriteLine("Press 4 to Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Menu_Balance(ref bank, ref client);
                    break;
                case 2:
                    Menu_add_in(ref bank, ref client);
                    break;
                case 3:
                    Menu_take_out(ref bank, ref client);
                    break;
                case 4:
                    Menu_exit(ref bank, ref client);
                    break;
                default :
                    Console.Clear();
                    Console.WriteLine("No such item in menu");
                    Menu_General(ref bank, ref client);
                    break;
            }

        }
        static public void Menu_exit(ref Bank bank, ref Client client)
        {
            Console.Clear();
            Console.WriteLine("Bey bey");
            Environment.Exit(0);
        }//done
        static public void Menu_Balance(ref Bank bank, ref Client client)
        {
            Console.WriteLine("In your account is: ");
            Console.WriteLine(client.Get_balance_value());
            Console.WriteLine("Press left Arrow to return to General menu all others key to Exit");
            ConsoleKeyInfo key;
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Menu_General(ref bank, ref client);
            }
            else
            {
                Menu_exit(ref bank, ref client);
            }

        }//done
        static public void Menu_take_out(ref Bank bank, ref Client client)
        {
            bank.Balaance_sync(client.take_maney_from_acc());
            Menu_Balance(ref bank, ref client);

        }
        static public void Menu_add_in(ref Bank bank, ref Client client)
        {
            bank.Balaance_sync(client.put_maney_from_acc());
            Menu_Balance(ref bank, ref client);
        }
        static void Main(string[] args)
        {
            //receive Pincode account number and first money on balance
            Bank Private = new Bank();
            Client client = new Client();
            if (client.Get_balance_value() == 0) {
                client.SetBankInfo(Private.GeneratAccount());
            }
            //non canonical input
            int posible = 3;
            while (posible > 0) {
            Console.WriteLine("Enter Pincode:\n");
            ConsoleKeyInfo keyInfo;
            StringBuilder val = new StringBuilder();
            int i = 4;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter&&i>0) {
                val.Append(keyInfo.KeyChar);
                Console.Write("*");
                i--;
            }
            string Pin = val.ToString();
            Console.Clear();
            if (Private.PinCorrect(Convert.ToInt32(Pin)) && client.PinCorrect(Convert.ToInt32(Pin))) {
                    Menu_General(ref Private, ref client);
                }
                else{
                Console.WriteLine(" NoN Correct\n");
            }
                posible--;
            }
        }
    }
}
