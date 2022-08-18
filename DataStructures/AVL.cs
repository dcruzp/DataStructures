using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class AVL<T> where T : IComparable<T>
    {
        AVLNode<T> _root;
        
        public AVL()
        {
            _root = null; 
        }

        public AVLNode<T> Insert (T item , AVLNode<T> node)
        {
            if (node == null) node = new AVLNode<T>(item); 
            
            //insert by left 
            if (item.CompareTo(node.Item) < 0)
            {

            }
            //insert by right 
            else if (item.CompareTo(node.Item) > 0)
            {

            }

            return node;
        }

        public AVLNode<T> LeftRotation (AVLNode<T> node , AVLNode<T> parent)
        {
            var right = node.Right;
            node.Right = right.Left;
            if (parent.Left == node) parent.Left = right;
            else parent.Right = right;

            return right;
            
        }
    }
}
