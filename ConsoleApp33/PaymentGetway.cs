using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public static class PaymentGetway
    {
        public static void AddMoney(ICard card, int amount)
        {
            card.AddMoney(amount);
        }

        public static void MakePayment (string phoneNumber, ICard card)
         {
            // beeline
            card.Pay(411);
        }

        public static void Transfer(ICard from, ICard to, int amount)
        {
            from.Pay(amount);
            to.AddMoney(amount);
        }
    }
}
