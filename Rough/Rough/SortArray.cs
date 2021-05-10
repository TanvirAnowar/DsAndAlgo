using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Rough
{
    public class SortArray
    {
        public static string Execute(string source)
        {
            var charArray = source.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = i+1; j < charArray.Length; j++)
                {
                    if (charArray[i] < charArray[j])
                    {
                        var temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                    }
                }
            }
            return new string(charArray);
        }

        public static string RemoveDuplicate(string source)
        {
            var charList = source.ToList();
            for (int i = 0; i < charList.Count; i++)
            {
                for (int j = i+1; j < charList.Count; j++)
                {
                    if (charList[i] == charList[j])
                    {
                        charList.RemoveAt(j);
                        j--;
                    }
                }
            }
            return string.Concat(charList);
        }

        public static char NthLargest(int position,string source)
        {
            var arrayPosition = position - 1;

            if (source.Length < position)
                throw new Exception();

            var sortedString = Execute(source);

            var duplicateRemovedString = RemoveDuplicate(sortedString);

            return duplicateRemovedString[arrayPosition];
        }
    }
}