using System.Collections.Generic;

namespace Rough
{
    public class ReversEachWord
    {
        public static string Execute(string sourceString)
        {
            var stringArray = sourceString.Split(" ");

            var stringList = new List<string>();
            foreach (var item in stringArray)
            {
                var word = reversWords(item);
                stringList.Add(word);
            }

            return string.Join(" ",stringList);
        }

        private static string reversWords(string item)
        {
            int stringLength = item.Length;
            char[] word = new char[stringLength];
            
            for (int i = stringLength - 1,j=0; i >= 0; i--,j++)
            {
                word[j] = item[i];

            }
            return new string(word);
        }
    }
}