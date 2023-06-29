using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter07.Examples.UserException
{
    internal class MyStyleException : Exception
    {
        public MyStyleException() { }   
        public MyStyleException(string message) : base(message) { }
    }
}
