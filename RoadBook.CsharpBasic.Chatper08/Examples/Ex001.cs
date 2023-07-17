using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadBook.CsharpBasic.Chatper08.Examples
{
    internal class Ex001
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine("디렉토리가 생성 되었습니다.");

            }
            Console.WriteLine("생성 경로 : {0}" , directoryInfo.FullName);
        }
    }
}
