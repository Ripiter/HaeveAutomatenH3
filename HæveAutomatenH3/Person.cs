using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    public class Person
    {
        public Person(string _name)
        {
            this.Name = _name;
        }

        private uint uniqueID;

        public uint UniqueID
        {
            get { return uniqueID; }
            set { uniqueID = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Account personalAccount;

        public Account PersonalAccount
        {
            get { return personalAccount; }
            set { personalAccount = value; }
        }

        /// <summary>
        /// Returns random card unless index is specified
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Card GetCard(int index = -1)
        {
            if(index != -1)
                return personalAccount.Cards[index];
            
            // Return random card
            return personalAccount.Cards[ new Random().Next(0, personalAccount.Cards.Count - 1)];
        }
    }
}
