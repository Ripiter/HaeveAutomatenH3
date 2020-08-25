using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Gorno");

            Bank bank = new Bank();
            bank.AddCustomer(person);

            int pinCode = 2345;
            float amountToWithDraw = 12f;

            if(bank.CorrectPincode(person.GetCard(0), pinCode))
            {
                Console.WriteLine("Correct pin code");

                if(bank.CanWithdraw(person.UniqueID, amountToWithDraw))
                {
                    Console.WriteLine(bank.Withdraw(person.UniqueID, amountToWithDraw));
                }
                else
                {
                    Console.WriteLine("Cant withdraw");
                }
            }
            else
            {
                Console.WriteLine("Wrong code");
            }

            Console.ReadLine();
        }
    }
}
