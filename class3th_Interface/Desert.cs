using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Desert : Terrain, Interface1
    {
        public Desert(int width, int height) : base(width, height) { }
        public override void Description()
        {
            Console.WriteLine("사막!"+"가로 :" + width+"세로 :" + height);
        }
        public void Stells()
        {
            Console.WriteLine("사막에서 엄폐성공");
        }
        public override void Activate()
        {
            Console.WriteLine("사막 탐험 중!");
        }

    }
}
