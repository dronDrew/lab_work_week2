using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            complex_number a=new complex_number(7,-4);
            complex_number b = new complex_number(3, 2);
            complex_number c = a / b;
            Console.WriteLine(c);
        }
    }
}
