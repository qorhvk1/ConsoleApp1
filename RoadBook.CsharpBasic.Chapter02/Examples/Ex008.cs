using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex008
    {
        public void Run() 
        {
            int number01 = 10;
            double number02 = number01;
            int number03 = (int)number02;

            Console.WriteLine("num01 변수 타입은 {0}",number01.GetType());
            Console.WriteLine("num02 변수 타입은 {0}",number02.GetType());
            Console.WriteLine("num03 변수 타입은 {0}",number03.GetType());

        }
    }
}
