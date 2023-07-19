using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadBook.CsharpBasic.Chapter06.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    internal class Ex015
    {
        public void Run()
        {
            List<Student> arrStudent = new List<Student>();

            Student student = new Student();

            student.Id = "S001";
            student.Name = "홍길동";
            student.Department = "국어 국문학과";
            student.Grade = "1";
            student.Age = 21;

            arrStudent.Add(student);

            for (int i =0; i<arrStudent.Count;i++)
            {
                Console.WriteLine(arrStudent[i].Id);
                Console.WriteLine(arrStudent[i].Name);
                Console.WriteLine(arrStudent[i].Department);
                Console.WriteLine(arrStudent[i].Grade);
                Console.WriteLine(arrStudent[i].Age);

            }
        }

    }
}
