using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    internal class Ex017
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
            var resultList = from s in students
                             where s.Grade ==1 || s.Grade ==3
                             select s;

            foreach (var result in resultList)
            {
                Console.WriteLine("{0} : {1}", result.Name,result.Major);
            }
        }
    }
}
