using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class CommandNode : Node
    {
        private Node node;

        public override void parse(Context context)
        {
            if (context.getCurrentToken().Equals("repeat"))
            {
                node = new RepeatCommandNode();
                node.parse(context);
            }
            else
            {
                node = new PrimitiveCommandNode();
                node.parse(context);
            }
        }

        public override string ToString()
        {
            return node.ToString();
        }
    }
}
