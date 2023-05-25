using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Q02
    {
        public void Run()
        {
            Console.WriteLine("중간 고사 점수를 입력해주세요");
            int middle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("기말 고사 점수를 입력해주세여");
            int final = Convert.ToInt32(Console.ReadLine());

            double average = (middle + final) / 2;
            if (average >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if(average >=80 && average < 90)
            {
                Console.WriteLine("B학점");
            }
            else if(average >=70 && average < 80)
            {
                Console.WriteLine("C학점");
            }
            else if (average < 70 && average >=0)
            {
                Console.WriteLine("F학점");
            }
            else { Console.WriteLine("잘못입력한듯"); }
        }
    }
}
