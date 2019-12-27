using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Decorator
{
    public class StringDisplay : Display
    {
        private string text;
        public StringDisplay(string text)
        {
            this.text = text;
        }
        
        public override int getColumns()
        {
            return text.Length;
        }

        public override int getRows()
        {
            return 1;
        }

        public override string getRowText(int row)
        {
            if (row == 0)
            {
                return text;
            }
            else
            {
                return null;
            }
        }
    }
}
