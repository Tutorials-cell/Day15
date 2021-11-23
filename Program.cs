using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BT obj1 = new BT();
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);
            obj1.TraverseInorder(obj1.root);
            Console.WriteLine();
            obj1.TraversePostorder(obj1.root);
            Console.WriteLine();
            obj1.TraversePreorder(obj1.root);
        }
    }
    
}
