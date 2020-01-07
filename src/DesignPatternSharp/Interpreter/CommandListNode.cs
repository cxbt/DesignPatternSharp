using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class CommandListNode : Node
    {
        private List<Node> list = new List<Node>();

        public override void parse(Context context)
        {
            while (true)
            {
                if (context.getCurrentToken() == null)
                {
                    throw new ParseException("Missing 'end' syntax");
                }
                else if (context.getCurrentToken().Equals("end"))
                {
                    context.skipToken("end");
                    break;
                }
                else
                {
                    Node commandNode = new CommandNode();
                    commandNode.parse(context);
                    list.Add(commandNode);
                }
            }
        }

        public override string ToString()
        {
            return string.Join(" ", list);
        }
    }
}
