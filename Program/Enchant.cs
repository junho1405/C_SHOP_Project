using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Enchant
    {
        public void Enchance(Item item)
        {
            if(item.Name == "Sword")
            {
                item.strength = 5;
            }
            else if(item.Name == "Necklace")
            {
                item.intelligente = 5;
            }
            else if(item.Name == "Shoes")
            {
                item.dexterity = 10;
            }
        }
    }
}
