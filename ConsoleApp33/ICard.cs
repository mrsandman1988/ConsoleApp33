using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public interface ICard
    {
        public void AddMoney(int amount);
        public bool Cash();
        public bool Pay(int amount);
        public bool Refund();

    }
}
