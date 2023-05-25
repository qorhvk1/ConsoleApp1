using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Q01
    {
        public void Run()
        {
            Random rand = new Random();
            int number = rand.Next(1,100);
            int number1 =rand.Next(1,100);

            int result = number + number1;
            
            Console.WriteLine("문제: {0}+{1} =  ?",number,number1);
            Console.WriteLine("정답을 입력해주세요 :");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == result)
            {
                Console.WriteLine("정답입니다");
            }
            else
            {
                Console.WriteLine("틀렷습니다");
            }
        }
    }
}
