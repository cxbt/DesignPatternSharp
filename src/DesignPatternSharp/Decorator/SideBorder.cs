using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Decorator
{
    public class SideBorder : Border
    {
        private char borderChar;
        public SideBorder(Display display, char ch) : base(display)
        {
            this.borderChar = ch;
        }

        public override int getColumns()
        {
            return display.getColumns() + 2;
        }

        public override int getRows()
        {
            return display.getRows();
        }

        public override string getRowText(int row)
        {
            return $"{borderChar}{display.getRowText(row)}{borderChar}";
        }
    }
}
