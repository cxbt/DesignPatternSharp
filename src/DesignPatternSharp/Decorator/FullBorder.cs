using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Decorator
{
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display)
        {

        }

        public override int getColumns()
        {
            return display.getColumns() + 2;
        }

        public override int getRows()
        {
            return display.getRows() + 2;
        }

        public override string getRowText(int row)
        {
            if (row == 0 || row == display.getRows() + 1)
            {
                return $"+{makeLine('-', display.getColumns())}+";
            }
            else
            {
                return $"|{display.getRowText(row - 1)}|";
            }
        }

        private string makeLine(char ch, int count)
        {
            StringBuilder buffer = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                buffer.Append(ch);
            }
            return buffer.ToString();
        }
    }
}
