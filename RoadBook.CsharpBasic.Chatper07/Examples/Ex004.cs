using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBookRoadBook.CsharpBasic.Chapter07.Examples
{
    internal class Ex004
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요 :");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("입력된 숫자는 {0}", number);
            }
            catch (Exception e)
            {
                Console.WriteLine(" 예외 상황 발생, 관리자에게 문의");
                Console.WriteLine("에러코드 : {0}", e.HResult);
                Console.WriteLine("에러 메세지 : {0}", e.Message);
            }
        }
    }
}
