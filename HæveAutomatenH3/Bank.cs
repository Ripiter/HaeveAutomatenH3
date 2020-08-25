using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public List<Account> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public Bank()
        {
            // TODO: Change customerdatabase to real database
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

        public bool CanWithdraw(uint userID, float amountToWithdraw)
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

        private void AddAccountToAccounts(Account account)
        {
            Accounts.Add(account);
        }            

        private Account GenerateAccount(Person person)
        {
            return new AccountFactory().Generate(person);
        }
    }
}
