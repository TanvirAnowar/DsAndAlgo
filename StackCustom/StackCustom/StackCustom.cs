using System;

namespace StackCustom
{
    public class StackCustom
    {
        private static int SIZE = 10;
        private int[] stackItems = new int[SIZE];

        private int count  = -1;

        public void Push(int item)
        {
            if(count == SIZE)
                throw new Exception();

            stackItems[++count] = item;
        }

        public int Pop()
        {
            if(IsEmpty())
                throw new Exception();

            var item = stackItems[count];
            
            stackItems[count] = 0;
            count--;

            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new Exception();

            var item = stackItems[count];

            stackItems[count] = 0;

            return item;
        }


        public bool IsEmpty()
        {
            return count == -1?true:false;
        }
    }
}