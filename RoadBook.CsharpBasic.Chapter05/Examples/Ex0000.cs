using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadBook.CsharpBasic.Chapter05.Examples;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    internal class Ex0000
    {
        public void Run()
        {
            Bread02 honey_butter_bread = new Bread02();
            SikBread02 garlic_bread = new SikBread02();

            honey_butter_bread.flavor = "맛있땅";
            honey_butter_bread.name = "허버브";
            Console.WriteLine("{0}의 맛은{1}", honey_butter_bread.name, honey_butter_bread.flavor);

            garlic_bread.name1();

            honey_butter_bread.name1() ;
            honey_butter_bread.flavor1() ;
            Console.WriteLine("{0}의 맛은{1}",garlic_bread.name );
        }
    }

    class Bread02
    {
        public string flavor {get;set ;}
        public string name { get;set ;}

        public void flavor1()
        {
            Console.WriteLine("맜잇당");
        }
        public void name1() {
            Console.WriteLine("허버브");
        }

        
    }
        
}
class SikBread02 : Bread02 { }