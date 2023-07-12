using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class Visa : BaseCard, ICard
    {
        public void AddMoney(int amount)
        {
            // connect to visa
            if(ExpireDate <= DateTime.Now)
            {
                throw new Exception("Card is expired");
            }
           
            // connecto to visa servers
        }

        public bool Cash()
        {
            // cash
            return true;
        }

        public bool Pay(int amount)
        {
            //
            if (true)
            {
                throw (new Exception(""));
            }
            return true;
        }

        public bool Refund()
        {
            //
            return true;
        }
    }
}
