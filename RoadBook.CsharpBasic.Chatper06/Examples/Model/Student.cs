﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter06.Examples.Model
{
    internal class Student
    {
        //<summary>
        //학생 아이디
        //</summary>

        public string Id { get; set; }

        //<summary>
        // 학생 이름
        //</summary>

        public string Name { get; set; }

        //<summary>
        //학생의 학과
        //</summary>

        public string Department { get; set; }
        //<summary>
        //학생 학년
        //</summary>
        public string Grade { get; set; }

        //<summary>
        // 학생 나이
        //</summary>
        public int Age { get; set; }
    }
}
