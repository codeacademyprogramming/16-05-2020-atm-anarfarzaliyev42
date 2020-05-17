using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Card
    {

        public string PAN;
        public string PIN { get; set; }
        public string CVC;
        public string ExpireDate;
        public decimal Balance { get; set; }
        public Card(string pan, string pin, string cvc, string expireDate, decimal balance)
        {
            PAN = pan;
            PIN = pin;
            CVC = cvc;
            ExpireDate = expireDate;
            Balance = balance;
        }
    }
}
