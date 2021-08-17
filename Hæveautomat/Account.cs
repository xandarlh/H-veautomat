using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomat
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AvailableAmount { get; set; }
        public Card Card { get; set; }

        public void SetupAccount(int pincode)
        {
            Card card = new Card(FirstName + " " + LastName, pincode, this);
            card.GenerateCardNumber();
            this.Card = card;
        }
        public bool Withdraw(double amount)
        {
            if (amount < AvailableAmount)
            {
                AvailableAmount = AvailableAmount - amount;
                return true;
            }

            return false;
        }
        public Account(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


    }
}
