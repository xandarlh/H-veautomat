using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hæveautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("alex", "lac");
            account.SetupAccount(1234);

            account.AvailableAmount = 19999;
            Console.WriteLine(account.Card.Withdraw(1234,122));
            Console.WriteLine(account.AvailableAmount);
            Console.ReadLine();
        }
    }
}
