using System.Collections.Generic;
using System.Linq;

namespace Rough
{
    public class RemoveDuplicateChar
    {
        public static string Execute(string sourceString)
        {
            var strChar = sourceString.ToList();
            var strLength = sourceString.Length;
            
            for (int i = 0; i < strChar.Count; i++)
            {
                if (strChar[i] == ' ')
                {
                    continue;
                }

              //  var strLengthTemp = strLength;
                for (int j = i+1; j < strChar.Count; j++)
                {
                    if (strChar[i] == strChar[j])
                    {
                        strChar.RemoveAt(j);
                        j--;
                    }
                }
            }
            return string.Concat(strChar);
        }
    }
}