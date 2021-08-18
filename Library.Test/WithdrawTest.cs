using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hæveautomat;
using Xunit;

namespace Library.Test
{
    public class WithdrawTest
    {
        [Fact]
        public void Withdraw_ShouldReturnAmount()
        {
            Account account = new Account("Alex","Lac");
            account.AvailableAmount = 10000;
            Card card = new Card(1234, account);
            string expected = "100";

            string actual = card.Withdraw(1234, 100);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Withdraw_ShouldRemoveFromAvailableAmount()
        {
            Account account = new Account("Alex", "Lac");
            account.AvailableAmount = 10000;
            Card card = new Card(1234, account);

            string expected = "9999";
            card.Withdraw(1234, 1);
            string actual = account.AvailableAmount.ToString();

            Assert.Equal(expected, actual);
        }
    }
}
