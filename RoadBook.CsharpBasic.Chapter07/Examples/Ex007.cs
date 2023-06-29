using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    internal class Ex007
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요 :");
            int number = -1;
            bool isException = false;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());


            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception : 숫자가 아닌 값을 입력했습니다");
                isException = true;

            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception : 숫자 범위를 초과했습니다");

                isException = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(" 예외 상황 발생, 관리자에게 문의");
                Console.WriteLine("에러코드 : {0}", e.HResult);
                Console.WriteLine("에러 메세지 : {0}", e.Message);

                isException = true;
            }
            finally
            {
                if (isException)
                {
                    number = 0;
                }
            }
            Console.WriteLine(" 입력된 숫자는 {0}", number);
        }
    }
}
