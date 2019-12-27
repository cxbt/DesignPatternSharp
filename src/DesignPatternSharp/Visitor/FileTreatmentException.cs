using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Visitor
{
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException()
        {

        }

        public FileTreatmentException(string msg) : base(msg)
        {

        }
    }
}
