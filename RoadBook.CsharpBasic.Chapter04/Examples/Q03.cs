using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    internal class Q03
    {
        public void Run()
        {
            Console.WriteLine("**************안녕하세요 은행입니다***************");
            Console.WriteLine("1: 잔액 조회");
            Console.WriteLine("2: 입금");
            Console.WriteLine("3: 출금");
            Console.WriteLine("0: 종료");

            int x = 0;
            int InMoney = 0;
            int OutMoney = 0;
            int TotalOutMoney = 0;
            int TotalInMoney = 0;
            
            while ((x = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                
                    if (x == 2)
                    {
                        Console.WriteLine("입금할 금액을 입력하세요");
                        InMoney = Convert.ToInt32(Console.ReadLine());
                        TotalInMoney += InMoney;
                        Console.WriteLine("입금되었습니다.");
                    }
                    if (x == 1)
                    {
                        Console.WriteLine("잔액은 {0} 원입니다", TotalInMoney - TotalOutMoney);
                    }
                    if (x == 3)
                    {
                        Console.WriteLine("출금할 금액을 알려주세요");
                        OutMoney = Convert.ToInt32(Console.ReadLine());

                        if (OutMoney > (TotalInMoney-TotalOutMoney))
                        {
                        Console.WriteLine("잔액이 부족합니다");
                        }
                        else
                        {
                        TotalOutMoney += OutMoney;
                        Console.WriteLine("출금되었습니다.");
                        }
                    }
                    if(x>=4 || x<0)
                     {
                        Console.WriteLine("1,2,3,0중에서 입력해주세요");
                     }

                

            }
            Console.WriteLine("감사합니다");
            
        }


    }
}
    

