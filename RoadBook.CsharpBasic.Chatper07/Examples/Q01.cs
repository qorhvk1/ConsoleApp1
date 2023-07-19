using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    internal class Q01
    {
        public void Run()
        {
            Console.WriteLine("정수를 입력해 주세요");
            int result = 0;
            try
            {
                 result = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (result != )
                {
                    result-- ;
                }
            }
        }
    }
}
