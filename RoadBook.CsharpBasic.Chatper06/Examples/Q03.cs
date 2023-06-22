using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Q03
    {
        public void Run()
        {
            Queue<string> que = new Queue<string>();

            Console.WriteLine("몇명에게 무료 혜택을 적용할까요?");
            int head =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("무료 영화 선착순 예매 시스템입니다");
            string de1 = "";
            while (true)
            {
                Console.WriteLine("이름을 입력해주세요(q: 종료)");
                que.Enqueue( de1= Convert.ToString(Console.ReadLine()));

                if(de1 == "q")
                {
                    break;
                }

                
                                
                
            }
            Console.WriteLine("무료 영화 관람권 당첨자는");
            for (int i = 0; i < head; i++)
            {
                Console.WriteLine("{0}",que.Dequeue());
            }

        }
    }
}
