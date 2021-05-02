using System;

namespace ArrayCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new[] {0,1, 2, 3, 4, 5};
            var arrayFunction = new ArrayFunction<int>(numberArray);

         //   arrayFunction.Insert(6);

            //arrayFunction.RemoveAt(1);
            //arrayFunction.RemoveAt(100);

            arrayFunction.InsertAt(2,22);

            Console.ReadKey();
        }
    }
}
