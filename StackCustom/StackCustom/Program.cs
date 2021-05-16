using System;

namespace StackCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "({[]})";
            string testString2 = "({[]}})";

            var validator = new ParenthesisValidator(testString2).Validate();
        }
    }
}
