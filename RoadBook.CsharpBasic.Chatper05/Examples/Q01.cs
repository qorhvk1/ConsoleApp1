using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    internal class Q01
    {
        public void Run()
        {

            Console.WriteLine("숫자 2개를 입력해주세요");
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();

            int num1= Convert.ToInt32(str);
            int num2 = Convert.ToInt32(str1);

            dynamic result1= Sum(num1,num2);
            dynamic result2 = Minus(num1,num2);
            dynamic result3 = Gobsem(num1,num2);
            dynamic result4 = Nanugi(num1,num2);

            Console.WriteLine("{0}과{1}의 덧셈값: {2} \n , 뺄셈값: {3}\n, 곱셈값: {4}\n , 나눗셈값: {5}", num1, num2,result1,result2,result3,result4);

           
        }

        private int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private int Minus( int num1, int num2)
        {
            return num1 - num2;
        }

        private int Gobsem(int num1, int num2)
        {
            return num1 * num2;
        }
        
        private double Nanugi(int num1, int num2)
        {
            return (double) num1 / num2;
        }
    }
}
