
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션         //
            //List<int> list = new List<int>();   
            //list.Add(10); //10
            //list.Add(20); //20
            //list.Add(30); //30
            //list.Add(40); //30
            //list.Add(50); //30
            //
            //list.Remove(40);
            //list.Insert(3,75);
            //
            //foreach(int element in list)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
            #region Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            int money = 0;
            dictionary.Add("Doran's Blade",450);
            dictionary.Add("BigFucking Swored",1300);
            dictionary.Add("Randuin's Omen",2700);

            //foreach (var element in dictionary)
            //{
            //    Console.WriteLine("KEY : "+$"{element.Key}");
            //    Console.WriteLine("VALUE : "+$"{element.Value}");
            //}

            string key = "Doran's ring";
            if (dictionary.TryGetValue(key, out money))
            {
                money = dictionary[key];
            }
            else
            {
                dictionary.Add(key, 400);
            }
            Console.WriteLine("Money : "+ money);
            foreach (var element in dictionary)
            {
                Console.WriteLine("KEY : "+$"{element.Key}");
                Console.WriteLine("VALUE : "+$"{element.Value}");
            }




            #endregion
        }
    }
}
