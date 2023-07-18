using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    class Ex005
    {
        private delegate int RunCalc(int a, int b);

        public void Run()
        {
            RunCalc calc = (a, b) => a + b;
            Console.WriteLine(calc(1, 2));

             calc = (a, b) => a * b;
            Console.WriteLine(calc(1, 2));
        }
    }
}
