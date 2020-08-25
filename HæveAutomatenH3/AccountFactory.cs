using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    class AccountFactory : IFactory<Account>
    {
        public Account Generate(Person person)
        {
            CardFactory cardFactory = new CardFactory();

            Account account = new Account(person.UniqueID);

            // Starting amount of money in the accout
            account.AmountInAccount = 100;

            // Add a new card to the account
            account.Cards.Add(cardFactory.Generate(person));

            return account;
        }
    }
}
