using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Mountain : Terrain, Interface1
    {
        public Mountain(int width, int height) : base(width, height) { }
        public override void Description()
        {
            Console.WriteLine("산!");
        }
        public void Stells()//부모클래스에 있는걸 써야한다.
        {
            Console.WriteLine("숨어따!");
        }
        public override void Activate()
        {
            Console.WriteLine("산 등반 중!");
        }
    }
}
