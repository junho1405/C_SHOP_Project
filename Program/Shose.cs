using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Shose : Item , Enchantable
    {
        public Shose() : base("Shose", 0, 10, 0)
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("힘 : " + strength);
            Console.WriteLine("민섭성 : " + dexterity);
            Console.WriteLine("능지 : " + intelligente);
        }
        public void Upgrade()
        {
            this.dexterity += 5;
            Console.WriteLine(name + "의 힘이" + dexterity + "로 증가");
        }
    }
}
