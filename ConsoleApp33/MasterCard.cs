using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class MasterCard : BaseCard, ICard
    {
        public void AddMoney(int amount)
        {
            throw new NotImplementedException();
        }

        public bool Cash()
        {
            throw new NotImplementedException();
        }

        public bool Pay(int amount)
        {
            throw new NotImplementedException();
        }

        public bool Refund()
        {
            throw new NotImplementedException();
        }
    }
}
