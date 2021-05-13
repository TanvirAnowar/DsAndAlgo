using System;

namespace ListCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            //linkedList.AddFirst(1);
            //linkedList.AddFirst(2);
            //linkedList.AddFirst(3);

            // var index = linkedList.IndexOf(1);

           // var exists = linkedList.Contains(5);

           // linkedList.RemoveFirst();
           //linkedList.RemoveLast();

           //var result = linkedList.ToArray();

           linkedList.Revers();

        }
    }
}
