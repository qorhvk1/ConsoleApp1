using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    internal class Ex014
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
            Dictionary<string, int> dictMajorCount = new Dictionary<string, int>();

            for (int idx =0; idx< students.Count; idx++)
            {
                if (!dictMajorCount.ContainsKey(students[idx].Major))
                {
                    dictMajorCount.Add(students[idx].Major, 1);
                }
                else
                {
                    dictMajorCount[students[idx].Major] = dictMajorCount[students[idx].Major] + 1;
                }
            }
            foreach (var key in dictMajorCount.Keys)
            {
                Console.WriteLine ( "{0} : {1} ", key, dictMajorCount[key]);
            }
        }
    }
}

