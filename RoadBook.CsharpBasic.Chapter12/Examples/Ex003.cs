using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadBook.CsharpBasic.Chapter12.Examples.Manager;

namespace RoadBook.CsharpBasic.Chapter12.Examples
{
    public class Ex003
    {
        public void Run()
        {
            CrawlManager cm =new Manager.CrawlManager();

            cm.Run();
        }
    }
}
