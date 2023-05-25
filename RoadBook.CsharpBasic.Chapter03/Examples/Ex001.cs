using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Ex001
    {
        public void Run()
        {
            const int zero = 0;


            if (zero == 0)
            {
                Console.WriteLine("첫번째 if문입니다.");
                Console.WriteLine("zero는 0이기 때문에 출력을합니다");
            }
            if(zero !=0)
            {
                Console.WriteLine("첫번째 else문입니다");
                Console.WriteLine("조건절 x 출력x");
            }

            if (zero == 1)
            {
                Console.WriteLine("두번째 if문입니다.");
                Console.WriteLine("zero 는 1이 아니기떄문에 출력안됌");
            }
            if(zero !=1)
            { 
                Console.WriteLine("두번쨰 else문입니당");
                Console.WriteLine("조건절에 해당하지않아서 출력 ");
            }

        }
    }
}
        
