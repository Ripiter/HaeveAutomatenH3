using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    class CardFactory : IFactory<Card>
    {
        public Card Generate(Person person)
        {
            // Should return random card number and pin code
            return new Card() { CardHolderName = person.Name, CardNumber = "2345", PinCode = 2345 };
        }
    }
}
