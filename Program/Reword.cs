using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Reword
    {
        //추가할거 : 경험치, 재화
        private int exp;
        private int money;

        public Reword(int exp, int money)
        {
            this.exp = exp;
            this.money = money;
        }

        public void Printf()
        {
            Console.WriteLine("퀘스트 보상");
            Console.WriteLine("경험치 : " + exp);
            Console.WriteLine("골드 : " + money);

        }

    }
}
