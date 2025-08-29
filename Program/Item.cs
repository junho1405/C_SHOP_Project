using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Item
    {
        protected string name;  
        protected int strength;
        protected int dexterity;
        protected int intelligente;
        //public string Name { get { return name; } }
        //public int strength { get { return Strength; } set { Strength = value; }}
        //public int dexterity { get { return Dexterity; } set { Dexterity = value; } }
        //public int intelligente { get { return Intelligente; } set { Intelligente = value; } }

        public Item(string name, int strength, int dexterity, int intelligente)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligente = intelligente;
        }
    }
}
