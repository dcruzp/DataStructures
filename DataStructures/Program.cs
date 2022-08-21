using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            AVL<int> _avl = new AVL<int>();
            _avl.Insert(2);
            _avl.Insert(3);
            _avl.Insert(4);
            _avl.Insert(1);
            _avl.Insert(0);

            _avl.Preorder();

            Console.WriteLine("------------------------------------");

            _avl.Inorder();
        }
    }
}
