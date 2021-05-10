using System;
using System.Text;

namespace Rough
{
    public class SubStringsOfAString
    {
        public static string Execute(string str)
        {
            var finaString = "";
            for (int i = 0; i < str.Length; i++)
            {
                var subString = "";
                for (int j = i; j < str.Length; j++)
                {
                    subString +=(str[j]);
                    //Console.Write(subString + " ");

                    finaString += subString+" ";
                }
            }

            return finaString;
        }
    }
}