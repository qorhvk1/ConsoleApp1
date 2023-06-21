using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex007
    {
        public void Run()
        {
            ArrayList list = new ArrayList();

            for (int idx = 0; idx< 10; idx++)
            {
                list.Add(idx);
            }
            for( int idx = 10; idx< 15; idx++)
            {
                list.Add(idx.ToString()); 
            }
            list.Insert(5, "100");

            for (int idx = 0; idx < list.Count; idx++)
            {
                Console.WriteLine("Value : {0} / Type : {1}",
                    list[idx], list[idx].GetType());

            }
        }
    }
}
