using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Necklace : Item, Enchantable
    {
        public Necklace() : base("Necklace", 10, 0, 0)
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("힘 : " + strength);
            Console.WriteLine("민섭성 : " + dexterity);
            Console.WriteLine("능지 : " + intelligente);
        }
        public void Upgrade()
        {
            this.intelligente += 5;
            Console.WriteLine(name + "의 지능이" + intelligente + "로 증가");
        }

    }
}
