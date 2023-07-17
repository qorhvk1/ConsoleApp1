using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadBook.CsharpBasic.Chatper08.Examples
{
    internal class Ex003
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            FileInfo fileinfo = new FileInfo(currentDirectory + @"\data\log.txt");

            Console.WriteLine("저장경로 : {0}", fileinfo.DirectoryName);
            Console.WriteLine("파일명 : {0}",fileinfo.Name);

            Console.WriteLine("===파일 내용===");
            using (StreamReader sr = new StreamReader(fileinfo.FullName))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null )
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
