using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex008
    {
        public void Run()
        {
            ArrayList a = new ArrayList();

            for(int i=0; i<10; i++)
            {
                a.Add(i);
            }
            for(int i=10; i<15; i++)
            {
                a.Add(i.ToString());
            }
            a.Insert(5, "100");

            for(int i=0; i<a.Count;i++)
            {
                Console.WriteLine("Value : {0} / Type : {1}", a[i], a[i].GetType());
            }
            a.RemoveAt(5);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("Value : {0} / Type : {1}", a[i], a[i].GetType());
            }

        }
    }
}
