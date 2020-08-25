using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenH3
{
    public class Card
    {
        private string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        private string cardHolderName;

        public string CardHolderName
        {
            get { return cardHolderName; }
            set { cardHolderName = value; }
        }

        private int pinCode;

        public int PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }

    }
}
