namespace Rough
{
    public class CircularArray
    {
        public static string LeftCircular(string sourceString)
        {
            char[] sourceChar = sourceString.ToCharArray();

            var arrayLength = sourceChar.Length;

            var temp = sourceChar[0];

            for (int i = 0; i < arrayLength-1 ; i++)
            {
                sourceChar[i] = sourceString[i + 1];
            }

            sourceChar[arrayLength - 1] = temp;


            return new string(sourceChar);
        }

        public static string RightCircular(string sourceString)
        {
            char[] sourceChar = sourceString.ToCharArray();

            var arrayLength = sourceChar.Length;

            var temp = sourceChar[arrayLength - 1];

            for (int i= arrayLength -1;i>0;i--)
            {
                sourceChar[i] = sourceChar[i - 1];
            }

            sourceChar[0] = temp;

            return new string(sourceChar);
        }


    }
}