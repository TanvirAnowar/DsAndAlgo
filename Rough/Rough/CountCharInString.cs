using System.Collections.Generic;

namespace Rough
{
    public class CountCharInString
    {
        public static Dictionary<char, int> Execute(string sourceString)
        {
            var charCount = new Dictionary<char,int>();
            for (int i = 0; i < sourceString.Length ; i++)
            {
                if (charCount.ContainsKey(sourceString[i]) == true)
                {
                    charCount[sourceString[i]]++;
                }
                else
                {
                    charCount.Add(sourceString[i],1);
                }
                
            }
            return charCount;
        }
    }
}