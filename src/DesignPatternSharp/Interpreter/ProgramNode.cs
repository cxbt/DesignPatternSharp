using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class ProgramNode : Node
    {
        private Node commandListNode;

        public override void parse(Context context)
        {
            try
            {
                context.skipToken("program");
                commandListNode = new CommandListNode();
                commandListNode.parse(context);
            }
            catch (ParseException e)
            {
                throw e;
            }
        }

        public override string ToString()
        {
            return $"[program {commandListNode}]";
        }
    }
}
