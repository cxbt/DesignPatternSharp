using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Composite
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
