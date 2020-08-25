using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HæveAutomatenH3;
using Xunit;

namespace AutomatenTest
{
    public class AccountTest
    {
        [Theory]
        [InlineData(200, 100, true)]
        [InlineData(100, 100, true)]
        [InlineData(10, 50, false)]
        public void CanWithDraw_SimpleCheck(float inAccount, float withdraw, bool expected)
        {
            Person person = new Person("Stefano");

            Bank bank = new Bank();
            bank.AddCustomer(person);

            person.PersonalAccount.AmountInAccount = inAccount;

            bool actual = person.PersonalAccount.CanWithdraw(withdraw); 

            // Asert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(1)]
        [InlineData(50)]
        public void WithDraw_SimpleCalculation(float withdraw)
        {
            Person person = new Person("Stefano");

            Bank bank = new Bank();
            bank.AddCustomer(person);

            string expected = "You just withdrew " + withdraw;
            
            string actual = person.PersonalAccount.WithDraw(withdraw);

            // Asert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Deposit_SimpleCalculation()
        {
            Person person = new Person("Stefano");

            Bank bank = new Bank();
            bank.AddCustomer(person);

            float amount = 120;

            string actual = person.PersonalAccount.Deposit(amount);

            string expected = "You have deposited " + amount + " your currect balance " + person.PersonalAccount.AmountInAccount;
            
            Assert.Equal(expected, actual);
        }
    }
}
