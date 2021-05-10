using System.Collections;
using System.Collections.Generic;

namespace Rough
{
    public class Parenthesis
    {
        public static bool IsValid(string source)
        {
            var sourceChar = source.ToCharArray();
            var parenthesis = new Stack<string>();

            foreach (var item in sourceChar)
            {

                if(item == '(')
                    parenthesis.Push("in");

                if (item == ')')
                {
                    if (parenthesis.Count == 0)
                        return false;
                    
                    parenthesis.Pop();
                    

                }
            }


            return parenthesis.Count==0?true:false;
        }
    }
}