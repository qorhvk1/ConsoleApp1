using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    internal class Q03
    {
        public void Run()
        {
            Console.WriteLine("**************안녕하세요 은행입니다***************");
            Console.WriteLine("1:계좌 만들기");
            Console.WriteLine("2: 잔액 조회");
            Console.WriteLine("3: 입금");
            Console.WriteLine("4: 출금");
            Console.WriteLine("0: 종료");

            int x = 0;
            int InMoney = 0;
            int OutMoney = 0;
            int TotalOutMoney = 0;
            int TotalInMoney = 0;
            Model.Account account = new Model.Account()
            {
                Name = "",
                Name1 = "",
                Money = 0
            };

            Account1 account1 = new Account1();
                

            while ((x = Convert.ToInt32(Console.ReadLine())) != 0)
            {   

                if (x==1)
                {
                    Console.WriteLine("통장 고유이름을 입력하세요 :");
                    account.Name = Console.ReadLine();
                    Console.WriteLine("통장 개설자의 이름을 입력하세요: ");
                    account.Name1 = Console.ReadLine();
                    Console.WriteLine("'{0}'님의 '{1}'이 개설되었습니다.", account.Name1, account.Name);


                    //Console.WriteLine("통장 고유 이름을 입력하세요 :");
                    //account1.Name = Console.ReadLine();
                    //Console.WriteLine("개설자의 이름을 입력하세요 :");
                    //account1.Name2 = Console.ReadLine();
                    //Console.WriteLine("{0}님의 {1}이 개설되었습니다.",account1.Name2,account1.Name);
                }

                if (x == 3)
                {
                    Console.WriteLine("입금할 금액을 입력하세요");
                    InMoney = Convert.ToInt32(Console.ReadLine());
                    TotalInMoney += InMoney;
                    Console.WriteLine("입금되었습니다.");
                }
                if (x == 2)
                {
                    Console.WriteLine("잔액은 {0} 원입니다", TotalInMoney - TotalOutMoney);
                }
                if (x == 4)
                {
                    Console.WriteLine("출금할 금액을 알려주세요");
                    OutMoney = Convert.ToInt32(Console.ReadLine());

                    if (OutMoney > (TotalInMoney - TotalOutMoney))
                    {
                        Console.WriteLine("잔액이 부족합니다");
                    }
                    else
                    {
                        TotalOutMoney += OutMoney;
                        Console.WriteLine("출금되었습니다.");
                    }
                }
                if (x >= 5 || x < 0)
                {
                    Console.WriteLine("1,2,3,0중에서 입력해주세요");
                }



            }
            Console.WriteLine("감사합니다");
        }
    }
}


public class Account1
{
    public string Name { get; set; }
    public string Name2 { get; set; }
    public int Money { get; set; }
}

