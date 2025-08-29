using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Enchant
    {
        public void Enchance(Enchantable item)
        {
            item.Upgrade();
            //if(item.Name == "Sword")
            //{
            //    item.strength = 10;
            //}
            //else if(item.Name == "Necklace")
            //{
            //    item.intelligente = 10;
            //}
            //else if(item.Name == "Shoes")
            //{
            //    item.dexterity = 10;
            //}
        }
    }
}
