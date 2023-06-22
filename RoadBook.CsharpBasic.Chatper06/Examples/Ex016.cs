using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex016
    {
        public void Run()
        {
            Queue<string> que = new Queue<string>();

            for (int i =1;i<11; i++)
            {
                que.Enqueue(string.Format("{0}번 승객"));
            }
            Console.WriteLine("* 정류장 승객 현황");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("===============");
            Console.WriteLine("버스가 도착했습니다. (6명 승차가능)");

            for (int i =0; i<6;i++)
            {
                que.Dequeue();
            }
            Console.WriteLine("버스가 출발했습니다");
            Console.WriteLine("======================");

            Console.WriteLine("새로운 승객이 줄을 섭니다");
            que.Enqueue("새로운 승객");

            Console.WriteLine("* 정류장 승객 현황");
            foreach (object obj in que)
            {
                Console.WriteLine(obj.ToString() );
            }
            Console.WriteLine("=========================");
        }
    }
}
