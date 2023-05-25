using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex006
    {
        public void Run()
        {
            #region >> 정수형 변수
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 20000;
            long longNumber = 50000;
            #endregion

            #region >> 실수형 변수
            float floatNumber = 3.14f;
            double dobuleNumber = 1.5;
            decimal deciamlNumber = 5.5m;
            #endregion

            Console.WriteLine("정수 : {0} , {1},{2},{3},{4}", shortByteNumber,
                byteNumber, shortNumber, intNumber, longNumber);
            Console.WriteLine("실수 : {0},{1},{2}",floatNumber, dobuleNumber, deciamlNumber);
        }
    }
}
