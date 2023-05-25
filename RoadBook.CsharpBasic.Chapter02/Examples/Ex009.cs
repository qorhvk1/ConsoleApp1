using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex009
    {
        public void Run()
        {
            string strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber);
            int parseNumber = int.Parse(strNumber);

            Console.WriteLine("{0} + {1} + {2}", convertNumber, 
                parseNumber,convertNumber+parseNumber);
        }
    }
}
