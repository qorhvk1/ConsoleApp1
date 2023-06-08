using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Ex003
    {
        public void Run()
        {
            const int number = 2;

            for (int index = 1; index < 10; index++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);
            }
        }
    }
}