using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Client
    {
        private int AcountNumb;
        private int Pin;
        public Client()
        {
            this.AcountNumb = 0;
            this.Pin = 0;
        }
        public void SetBankInfo(Tuple<int, int> a) {
            this.AcountNumb = a.Item1;
            this.Pin = a.Item2;
        }
    }
}
