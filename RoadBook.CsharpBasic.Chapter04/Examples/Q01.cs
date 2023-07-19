using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Q01
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요");
            int j= Convert.ToInt32(Console.ReadLine());
            int result = 1;
            
            for (int i = j;  i >0; i--)
            {

                result *= i;
            }
            Console.WriteLine("{0}!의 값은 : {1}",j ,result);
        }
    }
}
