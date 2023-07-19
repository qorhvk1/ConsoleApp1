using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex013
    {
       public void Run()
        {
            List<int> list = new List<int>();
            for( int  i =0; i < 15; i ++ )
            {
                list.Add(i);
            }
            list.Insert(5, 100);

            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine("Value : {0} / Type: {1}", list[i], list[i].GetType());
            }
            list.RemoveAt(5);

            for (int i =0; i < list.Count; i++)
            {
                Console.WriteLine("Value : {0} / Type {1}  ", list[i], list[i].GetType());  
            }
        }
    }
}
