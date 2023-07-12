using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public abstract class BaseCard
    {
        public string Number { get; set; }
        public DateTime ExpireDate { get; set; }
        public int CVV { get; set; }
        public void SendSms()
        {
            //logic for all
        }
    }
}
