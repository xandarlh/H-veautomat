using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomat
{
    public class Card
    {
        public string CardholderName { get; set; }

        public string Cardnumber { get; set; }

        public int Pincode { get; set; }

        public Account Account { get; set; }

        //Generates a random card number for the card(16 digits long)
        public string GenerateCardNumber()
        {
            Random random = new Random();
            int length = 16;
            string cardnumber = "";
            for (var i = 0; i < length; i++)
            {
                cardnumber += (random.Next(0, 10));
            }
            return cardnumber;
        }
        
        public string Withdraw(int pincode, double amount)
        {
            if (pincode == Pincode)
            {
                if (Account.Withdraw(amount))
                {
                    return amount.ToString();
                }
                else
                {
                    return "Not enought money";
                }
            }
            else
            {
                return "Wrong pin";
            }
        }
        public Card(int pincode, Account account)
        {
            this.CardholderName = account.FirstName + " " + account.LastName;
            this.Pincode = pincode;
            this.Account = account;
        }

    }
}
