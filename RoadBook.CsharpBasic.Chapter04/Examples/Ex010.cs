using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Ex010
    {
        public void Run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 10);

            Console.WriteLine("제가 생각하고 잇는 1~10 사이의 숫자를 맞춰");

            int count = 0;
            bool inMatched  = false;
            do
            {
                if (Convert.ToInt32(Console.ReadLine()) == target_number)
                {
                    inMatched = true;
                    Console.WriteLine("정답입니다 맞추기까지 {0}번 소요", count);
                }
                else
                {
                    Console.WriteLine("틀렸어");
                    count++;
                }
            } while (inMatched == false);
        }
    }
}
