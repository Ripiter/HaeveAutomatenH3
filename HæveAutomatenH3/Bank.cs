using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    public class Bank
    {
        public List<Account> Accounts = new List<Account>();

        public Bank()
        {
            // TODO: Change customer database to real database
            CustomerDatabase customerDatabase = new CustomerDatabase();
            Accounts = customerDatabase.GetAccounts();
        }


        public Account GetAccount(uint userID)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].AccountOwnerID == userID)
                    return Accounts[i];
            }
            return null;
        }

        public bool CanWithDraw(uint userID, float amountToWithdraw)
        {
            return GetAccount(userID).CanWithdraw(amountToWithdraw);
        }

        internal string Withdraw(uint userID, float amountToWithdraw)
        {
            return GetAccount(userID).WithDraw(amountToWithdraw);
        }

        /// <summary>
        /// Check if the card pin code is the same as user have wrote
        /// </summary>
        /// <param name="card"></param>
        /// <param name="inputPinCode"></param>
        /// <returns></returns>
        public bool CorrectPincode(Card card, int inputPinCode)
        {
            if (card.PinCode == inputPinCode)
                return true;

            return false;
        }

        public Account AddCustomer(Person person)
        {
            // Generate uniquie Id for a person
            person.UniqueID = (uint)Guid.NewGuid().GetHashCode();

            // Assign acount to the person
            person.PersonalAccount = GenerateAccount(person);

            // Add acount to all accounts
            AddAccountToAccounts(person.PersonalAccount);

            // Return account that person got
            return person.PersonalAccount;
        }

        internal void AddAccountToAccounts(Account account)
        {
            Accounts.Add(account);
        }
                
        internal Card GenerateCard(Person person)
        {
            return new Card() { CardHolderName = person.Name, CardNumber = "2345", PinCode = 2345 };
        }

        internal Account GenerateAccount(Person person)
        {
            Account account = new Account(person.UniqueID);

            // Starting amount of money in the accout
            account.AmountInAccount = 100;

            // Add a new card to the account
            account.Cards.Add(GenerateCard(person));

            return account;
        }
    }
}
