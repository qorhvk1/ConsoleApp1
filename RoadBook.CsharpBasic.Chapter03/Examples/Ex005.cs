using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    internal class Ex005
    {
        public void Run()
        {

            while (true)
            {
                Console.WriteLine("영화 제목을 입력해주세요");
                string movie = Console.ReadLine();
                Console.WriteLine("영화의 평점을 입력해주세요(1~5)");
                int score = Convert.ToInt32(Console.ReadLine());

                if (score == 'q')
                    break;

                switch (score)
                {
                    case 1:
                        Console.WriteLine("{0}영화는 최악", movie);
                        break;
                    case 2:
                        Console.WriteLine("{0}영화는 지루 ", movie);
                        break;
                    case 3:
                        Console.WriteLine("{0}영화는 킬링타임..", movie);
                        break;
                    case 4:
                        Console.WriteLine("{0}영화는 흥미 유발 ", movie);
                        break;
                    case 5:
                        Console.WriteLine("{0}영화는 최고의 영화", movie);
                        break;
                    default:
                        Console.WriteLine("평점계산에 실패");
                        break;
                }
            }
        }
    }
}
