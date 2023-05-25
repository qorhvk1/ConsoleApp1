using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Class1
    {
        public void Run()
        {
            Console.WriteLine("숫자 입력 ");
            string str = Console.ReadLine();
            Console.WriteLine("숫자 입력 ");
            string str1 = Console.ReadLine();

           int x=Convert.ToInt32(str1);
           int y=Convert.ToInt32(str);

             int sum = x + y;

        }
    }
}
