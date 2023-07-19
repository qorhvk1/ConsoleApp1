using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    internal class Ex003
    {
        public void Run()
        {
            Car003 car = new Car003();
            car.Size = "세단";
            car.Color = "하얀";

            Console.WriteLine("고객님의 차, {0},{1}이...",car.Color, car.Size);
            car.Engine_on();
            car.Go();
            car.Left();
            car.Back();
            car.Right();
            car.Engine_off();

        }
        class Car003
        {
            public string Color { get; set; }
            public string Size { get; set; }

            public void Engine_on()
            {
                Console.WriteLine("시켜");
            }
            public void Engine_off()
            {
                Console.WriteLine("시꺼");
            }

            public void Go()
            {
                Console.WriteLine("전진");
            }

            public 
                
                void Back()
            {
                Console.WriteLine("후진");
            }

            public void Left()
            {
                Console.WriteLine("왼쪽");
            }

            public void Right()
            {
                Console.WriteLine("오른쪽");
            }
        }
    }
}
