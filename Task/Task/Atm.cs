using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Atm
    {
        User user;
        public void GetPin()
        {
            Console.WriteLine("Please enter pin:");
            string pin = Console.ReadLine();
            CheckPin(pin);
        }
        public void CheckPin(string pin)
        {
            if (pin.Length == 4)
            {
                User[] users = GetAllUsers();
                foreach (var user in users)
                {
                    if (pin == user.CreditCard.PIN)
                    {
                        this.user = user;
                        Console.WriteLine($"Welcome {user.Name} {user.Surname}");


                        GetOperation();

                        return;
                    }

                }
                Console.WriteLine("Card not found");
            }
            else
            {
                Console.WriteLine("Invalid pin code");

            }
            GetPin();
        }
        public void GetOperation()
        {
            Console.WriteLine("Please select operation:\n1 Balans \n2 Nagd pul");
            int.TryParse(Console.ReadLine(), out int operation);
            if (operation == 1 || operation == 2)
            {
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Your balance is: {user.CreditCard.Balance} AZN");

                        break;
                    case 2:
                        Console.WriteLine($"Your Balance is {user.CreditCard.Balance} AZN");
                        Console.WriteLine("Please select balance option");
                        Console.WriteLine("1. 10 AZN \n2. 20 AZN \n3. 50 AZN \n4. 100 AZN \n5. Diger");
                        int.TryParse(Console.ReadLine(), out int option);
                        if (option >= 1 && option <= 5)
                        {
                            GetBalanceOption(option);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation");

            }
            GetOperation();

        }
        public void GetBalanceOption(int option)
        {
            decimal optionAmount = 0;
            switch (option)
            {
                case 1:
                    optionAmount = 10m;

                    break;
                case 2:
                    optionAmount = 20m;

                    break;
                case 3:
                    optionAmount = 50m;

                    break;
                case 4:
                    optionAmount = 100m;

                    break;
                case 5:
                    Console.WriteLine("Please enter amount of money");
                    decimal.TryParse(Console.ReadLine(), out decimal moneyAmount);
                    if (moneyAmount > 0 && moneyAmount <= user.CreditCard.Balance)
                    {
                        optionAmount = moneyAmount;


                    }
                    else if (moneyAmount > user.CreditCard.Balance)
                    {

                        Console.WriteLine("You don't have enough money");

                    }
                    else
                    {
                        Console.WriteLine("Invalid amount");

                    }

                    break;
                default:
                    break;
            }
            CheckBalance(optionAmount);
            GetOperation();
        }
        public void CheckBalance(decimal optionAmount)
        {
            if (user.CreditCard.Balance - optionAmount >= 0)
            {
                user.CreditCard.Balance -= optionAmount;
            }
            else
            {
                Console.WriteLine("You don't have enough money");
            }
        }
        public User[] GetAllUsers()
        {
            User[] users = new User[]
           {
                new User("John","Brown",new Card("1415478547693215","2535","473","06/22",235m)),
                new User("Lucy","Green",new Card("1415478547693215","3845","425","06/22",400m)),
                new User("Marry","Jane",new Card("1415478547693215","4535","436","06/22",10m)),
                new User("Jack","Blue",new Card("1415478547693215","2835","483","06/22",750m)),
                new User("Michael","White",new Card("1415478547693215","2725","496","06/22",150m))

           };
            return users;

        }
    }
}
