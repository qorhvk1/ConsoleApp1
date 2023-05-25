using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex007
    {
        public void Run()
        {
            dynamic rnrndj  = 100;
            dynamic duddj   = 100;
            dynamic tngkr = 98;
            dynamic cpdbr = 97;

            Console.WriteLine("4과목의 총점수는 = {0}", (rnrndj + duddj + tngkr + cpdbr));
            Console.WriteLine("4과목의평균은 = {0}",((double)(rnrndj+duddj+tngkr+cpdbr)/4));
        }
    }
}
