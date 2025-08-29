using System;
using System.Collections.Generic;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 단일책임원칙
            // 클래스의 구성 단위가 하나의 책임만 가질 수 있도록
            // 설계해야하는 원칙입니다.
            //Quest quest01 = new Quest("패링연습", "패링을 성공하세요.", new Reword(300,500));
            //Quest quest02 = new Quest("전투연습", "적을 처치하세요.", new Reword(750, 2500));
            //Quest quest03 = new Quest("회피연습", "회피를 성공하세요.", new Reword(500, 1500));
            //
            //List<Quest> quests = new List<Quest>();
            //quests.Add(quest01);
            //quests.Add(quest02);
            //quests.Add(quest03);
            //// 퀘스트를 넣는 배열을 만든 뒤에 그 배열에 퀘스트 추가
            //
            //for (int i = 0; i < quests.Count; i++)
            //{
            //    quests[i].printf();
            //}
            #endregion
            #region 개방 폐쇄 원칙
            // 소프트웨어의 구성 요소는 확장에는 열려 있어야 하고, 변경에는 닫혀 있어야 한다. 
            // 

            //Enchant enchant = new Enchant();
            //enchant.Enchance(new Sword());
            //enchant.Enchance(new Necklace());
            //enchant.Enchance(new Shose());

            //enchant.Enchance(new Item("Sword", 10, 5, 0));
            //enchant.Enchance(new Item("Necklace", 1, 1, 10));
            //enchant.Enchance(new Item("Shose", 0, 20, 1));



            #endregion
            #region 인터페이스 분리원칙
            // 클래스가 자신이 사용하지 않는 함수에 의존하지 않도록
            // 설계되어야 하는 원칙입니다. 
            // 
            // (상인, 공주, 용병)-(교환, 도주, 공격)

            Princess princess = new Princess();
            princess.Move();

            Dragoon dragoon = new Dragoon();
            dragoon.Move();
            dragoon.ATK(88);

            Shop shop = new Shop();
            shop.Trade();
            #endregion
        }
    }
}
