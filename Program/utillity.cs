using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Program
{
    internal class utillity
    {
        private int data;
        public void Pause()
        {
            Console.WriteLine("Pause....");
        }
        public void Swap(ref int x, ref int y)
        {
            int temporary = x;
            x = y;
            y = temporary;
            //Swap(ref x, ref y);
        }
        public int Absolute(in int value)
        {
            return value < 0 ? -value : value;
            //if (value < 0) Console.WriteLine("절대값 : " + (value)*-1);
            //if (value > 0) Console.WriteLine("절대값 : " + value);

        }
    }
}
