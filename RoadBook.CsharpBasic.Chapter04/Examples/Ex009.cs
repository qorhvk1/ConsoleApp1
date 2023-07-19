using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Ex009
    {
        public void Run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 10);

            Console.WriteLine("제가 생각하고있는 1~10 사이의 숫자를 맞춰 (0입력시 힌트) "
                );

            int count = 0;
            int answer = 0;
            while ((answer = Convert.ToInt32(Console.ReadLine())) !=target_number)
            {
                if(answer ==0)
                {
                    Console.WriteLine("힌트 : 제가 생각하고 있는 숫자는 2로 나누엇을때 나머지가 {0} 입니다", target_number % 2);
                    continue;
                }
                Console.WriteLine("틀렸아요");
                count++;
            }
            Console.WriteLine("정답입니다 맞추기까지 {0}번 소요", count);
        }
    }
}
