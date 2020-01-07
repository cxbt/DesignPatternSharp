using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class ParseException : Exception
    {
        public ParseException(string msg) : base(msg)
        { 

        }
    }
}
