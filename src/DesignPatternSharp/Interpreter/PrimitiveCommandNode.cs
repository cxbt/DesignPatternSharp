using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class PrimitiveCommandNode : Node
    {
        private string name;

        public override void parse(Context context)
        {
            name = context.getCurrentToken();
            context.skipToken(name);
            if (!name.Equals("go") && !name.Equals("right") && !name.Equals("left"))
            {
                throw new ParseException($"{name} is undefined");
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
