using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Swamp : Terrain, Interface1
    {
        public Swamp(int width, int height) : base(width, height) { }
        public override void Description()
        {
            Console.WriteLine("늪! " + "가로 : " + width + "세로 : " + height);
        }
        public void Stells()
        {
            Console.WriteLine("늪 은폐 성공");
        }
        public override void Activate()
        {
            Console.WriteLine("늪 탐험 중!");
        }

    }
}
