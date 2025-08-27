using System;
using System.Collections.Generic;

namespace Program
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            #region 추상클래스
            // 직접 생성할 수는 없지만, 다른 클래스가 상속받아 구체적인 기능을 만들 수
            // 있도록 설계되어 있는 클래스입니다.
            // 

            Terrain terrain = new Forest(20,50);
            terrain.Description();

            terrain = new Mountain(20,40);
            terrain.Description();

            terrain = new Desert(5,10);
            terrain.Description();
            ((Interface1)terrain).Stells();

            terrain = new Swamp(30,50);
            ((Interface1)terrain).Stells();
            terrain.Description();


            #endregion
        }
    }
}
