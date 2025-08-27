namespace Class2th_Colection
{
    internal class Class2th
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
            dictionary.Add("Doran's Blade", 450);
            dictionary.Add("BigFucking Swored", 1300);
            dictionary.Add("Randuin's Omen", 2700);

            //foreach (var element in dictionary)
            //{
            //    Console.WriteLine("KEY : "+$"{element.Key}");
            //    Console.WriteLine("VALUE : "+$"{element.Value}");
            //}

            // string key = "Doran's ring";
            // if (dictionary.TryGetValue(key, out money))
            // {
            //     money = dictionary[key];
            // }
            // else
            // {
            //     dictionary.Add(key, 400);
            // }
            // Console.WriteLine("Money : "+ money);
            // foreach (var element in dictionary)
            // {
            //     Console.WriteLine("KEY : "+$"{element.Key}");
            //     Console.WriteLine("VALUE : "+$"{element.Value}");
            // }
            #endregion
            #region 스택
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);
            //
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop()); 
            //}

            #endregion
            #region 큐(Queue)
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(10);  
            //queue.Enqueue(20);  
            //queue.Enqueue(30);  
            //queue.Enqueue(40);
            //queue.Enqueue(50);
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            #endregion
            #region LinkedList
            //LinkedList<int> linkedList = new LinkedList<int>();
            //
            //linkedList.AddLast(10);
            //linkedList.AddLast(5);
            //linkedList.AddLast(1);          
            //linkedList.AddLast(20);
            //foreach(int element in linkedList)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion
        }
    }
}
