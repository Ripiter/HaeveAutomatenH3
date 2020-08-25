using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HæveAutomatenH3;

namespace AutomatenTest
{
    public class BankTests
    {
        [Fact]
        public void GetAccount_ReturnAccout()
        {
            Bank bank = new Bank();

            // Expected
            Account expected = bank.Accounts[0];

            // Act
            Account actual = bank.GetAccount(0);

            // Asert
            Assert.Equal<Account>(expected, actual);

        }

        [Fact]
        public void CanWithDraw_SimpleCheck()
        {
            Bank bank = new Bank();

            // expected
            bool expected = true;

            // Act
            bool actual = bank.CanWithDraw(0, 10);

            // Asert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CorrectPincode_SimpleCheck()
        {
            Bank bank = new Bank();
            Person person = new Person("Gorno");

            bank.AddCustomer(person);

            // Expected
            bool expected = true;

            // Actual
            bool actual = bank.CorrectPincode(person.GetCard(0), person.GetCard(0).PinCode);

            // Asert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddCustomer_AddingToList()
        {
            Bank bank = new Bank();
            Person person = new Person("Stefano");

            bank.AddCustomer(person);
            
            // Asert
            Assert.Contains(person.PersonalAccount, bank.Accounts);
        }
    }
}
