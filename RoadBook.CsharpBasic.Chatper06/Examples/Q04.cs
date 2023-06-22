using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Q04
    {
        public void Run()
        {
            
            
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            List<string> list = new List<string>();
            List<string> list1 = new List<string>();

            list1.Add("일본");
            list1.Add("브라질");
            list1.Add("독일");
            list1.Add("스페인");

            list.Add("대한민국");
            list.Add("프랑스");
            list.Add("미국");
            list.Add("이집트");

            dict.Add("A", list);
            dict.Add("H", list1);

            while(true)
            {
                Console.WriteLine("조 추첨 결과 어느 조를 조회할까요? (q: 종료)");
                string word = Console.ReadLine();

                if(word == "q")
                {
                    break;
                }
                if (dict.ContainsKey(word)) 
                {
                    Console.WriteLine("{0}에 속한 나라는 : {1}", word, dict[word]);
                }
            }
        }
    }
}


