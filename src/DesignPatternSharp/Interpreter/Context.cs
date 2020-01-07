using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternSharp.Interpreter
{
    public class Context
    {
        private Queue<string> tokenizer;
        private string currentToken;

        public Context(string text)
        {
            tokenizer = new Queue<string>(text.Split(' '));
            nextToken();
        }

        public string nextToken()
        {
            if (tokenizer.Any())
            {
                currentToken = tokenizer.Dequeue();
            }
            else
            {
                currentToken = null;
            }
            return currentToken;
        }

        public string getCurrentToken()
        {
            return currentToken;
        }

        public void skipToken(string token)
        {
            if (!token.Equals(currentToken))
            {
                throw new ParseException($"Warning: {token} is expected, but {currentToken} is found.");
            }
            nextToken();
        }

        public int currentNumber()
        {
            int number = 0;
            try
            {
                number = Int32.Parse(currentToken);
            }
            catch (FormatException e)
            {
                throw new ParseException($"Warning: {e}");
            }
            return number;
        }
    }
}
