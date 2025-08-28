using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Quest
    {
        private string title;
        private string description;
        private bool completed = false;

        private Reword reword;
        public Quest(string title, string description, Reword reword)
        {
            //bool은 어디에?
            this.title = title; 
            this.description = description;
            this.reword = reword;

        }
        public void printf ()
        {
            Console.WriteLine("퀘스트 제목 : " + title);
            Console.WriteLine("퀘스트 내용 : " + description);
            reword.Printf();
            Console.WriteLine();

        }

    }
}
