using System.Collections.Generic;

namespace Rough
{
    public class ReversWords
    {
        public static string Revers(string sourceString)
        {
            var stringArray = sourceString.Split(" ");

            var wordList = new List<string>();
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                wordList.Add(stringArray[i]);

                //if(i != 0)
                //    wordList.Add(" ");
            }
            return string.Join(" ",wordList);
        }
    }
}