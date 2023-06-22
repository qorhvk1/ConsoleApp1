using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Q02
    {
        public void Run()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("숫자를 입력해주세요:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
             
            Array.Sort(arr);

            Console.WriteLine("오름차순 정렬 결과 {0} ,{1},{2},{3},{4}", arr[0], arr[1], arr[2], arr[3], arr[4]  );
        }
    }
}
