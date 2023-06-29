using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    internal class Ex002
    {
        public void Run()
        {
            List<string> list = new List<string>();

            list.Add("Hi");
            Console.WriteLine(list[0]);
            
            list.Clear();
            Console.WriteLine(list[0]);

        }
    }
}
