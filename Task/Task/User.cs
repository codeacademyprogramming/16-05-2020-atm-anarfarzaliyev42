using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class User
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public Card CreditCard { get; set; }
        public User(string name, string surname, Card creditCard)
        {
            Name = name;
            Surname = surname;
            CreditCard = creditCard;
        }

    }
}
