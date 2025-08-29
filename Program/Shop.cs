using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Shop : Trade
    {
        public void Trade()
        {
            Console.WriteLine("상인과 거래를 하겠습니까 Y/N");
            Console.WriteLine();
        }
    }
}
