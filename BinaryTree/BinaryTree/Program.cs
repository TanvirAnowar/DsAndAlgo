using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(6);
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(9);

            //var exist = tree.Find(2);
            // var notExist = tree.Find(10);

     //       tree.DepthFirstTravers();
            var height = tree.HeightOfTree();
            Console.WriteLine(height);


        }
    }
}
