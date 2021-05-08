namespace Rough
{
    public class Palindrome
    {
        public static bool PalindromeExecute(string sourceString)
        {
            int stringLength = sourceString.Length;
            for (int i = 0,j=stringLength-1; i <= stringLength / 2; i++,j--)
            {
                if (sourceString[i] != sourceString[j])
                    return false;
            }
            return true;
        }
    }
}