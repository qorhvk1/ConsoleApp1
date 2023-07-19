using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Q01
    {
        public void Run()
        {
            int[] age = new int[10];

            int undertwo = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int upsix = 0;

            for(int i=0; i<age.Length; i++)
            {
                Console.WriteLine("{0}번째 사람의 나이를 입력하세요", i + 1);
                int age2 = Convert.ToInt32(Console.ReadLine());

                if (age2 > 0 && age2 < 20) undertwo++;
                if (age2 >= 20 && age2 < 30) two++;
                if (age2 >= 30 && age2 < 40) three++;
                if (age2 >= 40 && age2 < 50) four++;
                if (age2 >= 50 && age2 < 60) five++;
                if (age2 >= 60) upsix++;

            }
            
            Console.WriteLine("나이 입력이 완료되었습니다.");
            
            Console.WriteLine("20대 미만 : {0}명 / 20대 : {1}명 / 30대: {2}명/ 40대:{3}명 / 50대: {4}명 / 60대이상: {5}명", undertwo, two, three, four, five, upsix);


        }
    }
}
