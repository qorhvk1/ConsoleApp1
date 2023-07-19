using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Q02
    {
        public void Run()
        {
            Random r = new Random();
            int number = r.Next(1, 50);
            Console.WriteLine("1~50까지의 숫자를 맞춰라");
            int x = 0;
            while (( x=Convert.ToInt32(Console.ReadLine())) != number)
            {
                if(number < x)
                {
                    Console.WriteLine("틀렸습니다 DOWN!");
                }
                else
                {
                    Console.WriteLine("틀렸습니다 UP!");
                }

            }
            Console.WriteLine("정답입니다!");
        }
    }
}
