using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Ex003
    {
        public void Run()
        {
            Console.WriteLine("숫자를입력하세요");
            int x = Convert.ToInt32(Console.ReadLine()); 
            

            if (x > 0)
            {
                Console.WriteLine("{0}는 양수입니다 ",x);
            }
            else if (x < 0)
            {
                Console.WriteLine("{0}는 음수입니다",x);
            }
            else
            {
                Console.WriteLine("{0}=는 0입니다", x);
            }
            if (x%2 == 0)
            {
                Console.WriteLine("{0}는 짝수입니다", x);
            }
            if(x%2 == 1)
            {
                Console.WriteLine("{0}는 홀수입니다", x);
            }
        }
    }
}
