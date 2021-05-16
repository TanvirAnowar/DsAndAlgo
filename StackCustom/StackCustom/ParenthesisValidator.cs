using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCustom
{
    public class ParenthesisValidator
    {
        private string SourceString { get; set; }
        private char[] LeftBracket = new char[]{ '(', '{', '['};
        private char[] RightBracket = new char[]{ ')', '}', ']'};

        private Stack<char> BracketStack { get; set; } = new Stack<char>();

        public ParenthesisValidator(string sourceString)
        {
            SourceString = sourceString;

        }

        public bool Validate()
        {
            foreach (var item in SourceString)
            {
                if (LeftBracket.Contains(item))
                {
                    BracketStack.Push(item);
                    continue;
                }
                
                if (RightBracket.Contains(item) && BracketStack.Any())
                {
                    var itemToMatch = BracketStack.Pop();

                    var leftIndex = Array.IndexOf(LeftBracket, itemToMatch);

                    var rightIndex = Array.IndexOf(RightBracket, item);

                    if (leftIndex != rightIndex)
                        return false;
                }
                
            }
            return true;
        }
    }
}
