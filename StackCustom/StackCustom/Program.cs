using System;

namespace StackCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "({[]})";
          //  string testString2 = "({[]}})";

          //  var validator = new ParenthesisValidator(testString2).Validate();

          var stackCustom = new StackCustom();

          stackCustom.Push(1);
          stackCustom.Push(-1);
          stackCustom.Push(0);

          var item = stackCustom.Peek();

          stackCustom.Pop();
          stackCustom.Pop();
          stackCustom.Pop();

          stackCustom.IsEmpty();

          stackCustom.Pop();
        }
    }
}
