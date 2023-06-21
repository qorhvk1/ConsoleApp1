using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex010
    {
        public void Run()
        {

            Stack stk = new Stack();

            Console.WriteLine("* 시작점");
            for (int i =1; i<11; i++)
            {
                Console.WriteLine("{0}번 선수 도착", i);
                stk.Push(string.Format("{0}번 선수", i));
            }
            Console.WriteLine("========");
            Console.WriteLine("5~10등 선수는 탈락합니다.");
            for (int i= 0; i <6; i++)
            {
                stk.Pop();
            }
            Console.WriteLine("======");
            
            Console.WriteLine("* 올림픽 대표선수 명단");
            foreach (object obj in stk)
            {
                Console.WriteLine(obj.ToString());
            }

        }
        

    }
}
