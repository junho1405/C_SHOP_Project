using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Forest : Terrain, ITraversable
    {
        public override void Activate()
        {
            Console.WriteLine("Traverse : " + Traverse());
        }
        public Forest(int width, int height) : base(width, height) { }
        public override void Description()
        {
            Console.WriteLine("숲!");
        }
        public bool Traverse()
        {
            return true;
        }
    }
}
