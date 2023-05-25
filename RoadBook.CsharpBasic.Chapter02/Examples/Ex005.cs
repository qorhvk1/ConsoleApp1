using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex005
    {
        public void Run()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";
            

            bool isContainsWord001 = objHello.ToString().Contains("Hello");
            bool isContainsWord002 = vHello.ToString().Contains("Hello");
            bool isContainsWord003 = dHello.ToString().Contains("Hello");

            Console.WriteLine("object 변수에 Hello가 포함? {0}", isContainsWord001);
            Console.WriteLine("var 변수에 Hello 가 포함? {0}", isContainsWord002);
            Console.WriteLine("dynamic 변수에 Hello 가 포함? {0}", isContainsWord003);
        }
    }
}
