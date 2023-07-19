using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadBook.CsharpBasic.Chatper08.Examples
{
    internal class Ex002
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            using (StreamWriter sw = new StreamWriter 
                (currentDirectory +@"\data\log.txt",true))

            {
                sw.WriteLine("프로그램 실행 시간: {0}", DateTime.Now);
            }
        }
    }
}
