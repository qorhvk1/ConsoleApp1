using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    internal class Ex015
    {
        public void Run()
        {
            List<Model.Student> students = new List<Model.Student>()
            {
                new Model.Student { ID= "S001" , Name = "Dexter", Grade = 3, Major = "Software"},
                new Model.Student { ID = "D001", Name = "Ellin", Grade = 3, Major ="Design"},
                new Model.Student {ID = "S002", Name = "Jeffrey", Grade = 4 , Major = "Software"},
                new Model.Student {ID = "D002", Name = "Sienna", Grade = 4, Major= "Design"},
                new Model.Student {ID = "S003", Name = "Pil", Grade = 4, Major= "Design"},
                new Model.Student {ID = "S006", Name = "Clint", Grade = 3, Major= "Design"},
                new Model.Student {ID = "S004", Name = "Khan", Grade = 2, Major= "Design"},
                new Model.Student {ID = "A001", Name = "Mike", Grade = 2, Major= "Design"},
                new Model.Student {ID = "S005", Name = "Sven", Grade = 2, Major= "Design"},
                new Model.Student {ID = "T001", Name = "Peter", Grade = 1, Major= "Design"},
            };

            int sum = 0;
            int max = 0;
            int min = 100;
            double avg = 0;

            for( int idx =0; idx< students.Count; idx++)
            {
                int grade = students[idx].Grade;

                sum += grade;

                if(max< grade)
                {
                    max = grade;
                }
                if (min > grade)
                {
                    min = grade;
                }
            }

            avg = sum /(double )students.Count;
            Console.WriteLine("Sum : {0}",sum);
            Console.WriteLine("Max : {0}", max);
            Console.WriteLine("Min : {0}", min);
            Console.WriteLine("Avg : {0}", avg);
        }
    }
}

