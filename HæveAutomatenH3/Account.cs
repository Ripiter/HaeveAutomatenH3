using System.Collections.Generic;

namespace HæveAutomatenH3
{
    public class Account
    {
        public Account(uint _personID)
        {
            AccountOwnerID = _personID;
        }

        private List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }


        private uint accountOwnerID;

        public uint AccountOwnerID
        {
            get { return accountOwnerID; }
            set { accountOwnerID = value; }
        }


        private float amountInAccount;

        public float AmountInAccount
        {
            get { return amountInAccount; }
            set { amountInAccount = value; }
        }

        public bool CanWithdraw(float amountToWithdraw)
        {
            if (this.AmountInAccount >= amountToWithdraw)
                return true;

            return false;
        }

        public string WithDraw(float amount)
        {
            if (CanWithdraw(amount))
            {
                this.AmountInAccount -= amount;
                return "You just withdrew " + amount;
            }

            return "You Dont have enough money on your account";
        }

        public string Deposit(float amount)
        {
            this.AmountInAccount += amount;

            return "You have deposited " + amount + " your currect balance " + AmountInAccount;
        }

    }
}
