using System.Xml.Linq;

namespace Program
{
    internal class Sword : Item, Enchantable
    {
        public Sword() : base("Sword", 10, 0, 0)

        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("힘 : " + strength);
            Console.WriteLine("민섭성 : " + dexterity);
            Console.WriteLine("능지 : " + intelligente);
        }

        public void Upgrade()
        {
            this.strength += 5;
            Console.WriteLine(name + "의 힘이" + strength + "로 증가");
        }
    }
}
