using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Ex001
    {
        public void Run()
        {
            const int number = 2;
            int index = 1;

            for (; ; )
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);
                break;
            }
        }
    }
}
