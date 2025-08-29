using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Dragoon : Move, ATK
    {
        public void Move()
        {
            Console.WriteLine("용기병이 돌진합니다.");
        }
        public void ATK(float damage)
        {
            Console.WriteLine("용기병이 공격합니다.");
            Console.WriteLine(damage + "의 피해를 입었습니다.");
            Console.WriteLine();
        }
    }
}
