using System;

namespace Rough
{
    public class StringRevers
    {
        public static string Revers(string sourceString)
        {
            var stringLength = sourceString.Length;

            char[] targetString = new char[stringLength];

            for (int i = stringLength -1,j=0; i >= 0; i--,j++)
            {
                targetString[j] = sourceString[i];
            }


            return new string(targetString);

        }
    }
}