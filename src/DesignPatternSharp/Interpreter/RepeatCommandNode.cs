using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class RepeatCommandNode : Node
    {
        private int number;
        private Node commandListNode;
        public override void parse(Context context)
        {
            context.skipToken("repeat");
            number = context.currentNumber();
            context.nextToken();
            commandListNode = new CommandListNode();
            commandListNode.parse(context);
        }

        public override string ToString()
        {
            return $"[repeat {number} {commandListNode}]";
        }
    }
}
