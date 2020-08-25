using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    class CustomerDatabase
    {
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            List<Person> people = GetPeople();

            for (int i = 0; i < people.Count; i++)
            {
                accounts.Add(new Account((uint)i) { Cards = GetCards(people[i].Name) });
                accounts[i].AmountInAccount = 150;
            }

            return accounts;
        }

        public List<Card> GetCards(string name)
        {
            List<Card> cards = new List<Card>();

            cards.Add(new Card() { CardHolderName = name, CardNumber = "1234", PinCode = 1234 });
            cards.Add(new Card() { CardHolderName = name, CardNumber = "4321", PinCode = 4321 });

            return cards;
        }
                     
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add( new Person("Jon"));
            people.Add( new Person("Steve"));
            return people;
        }
    }
}
