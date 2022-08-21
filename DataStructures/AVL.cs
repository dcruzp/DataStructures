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

        public void Insert (T item)
        {
            _root = _insert(item, _root);
        }

        private AVLNode<T> _insert (T item , AVLNode<T> node)
        {
            if (node == null) return new AVLNode<T>(item); 
            
            //insert by left 
            if (item.CompareTo(node.Item) < 0)
            {
                node.Left = _insert(item, node.Left); 
            }
            //insert by right 
            else if (item.CompareTo(node.Item) > 0)
            {
                node.Right = _insert(item, node.Right); 
            }
            return node;
        }

       

        private AVLNode<T> LeftRotation (AVLNode<T> node , AVLNode<T> parent)
        {
            var right = node.Right;
            node.Right = right.Left;
            if (parent.Left == node) parent.Left = right;
            else parent.Right = right;

            return right;
            
        }

        private  AVLNode<T> RightRotation (AVLNode<T> node, AVLNode<T> parent)
        {
            var left = node.Left;
            node.Left = left.Right;
            if (parent.Left == node) parent.Left = left;
            else parent.Right = left;

            return left; 
        }

        public void Preorder()
        {
            if (this._root != null) _preorder(_root);
        }

        public void Posorder()
        {
            if (this._root != null) _posorder(_root); 
        }

        public void Inorder()
        {
            if (this._root != null) _inorder(_root);
        }

        private void _preorder (AVLNode<T> node)
        {
            if (node.Left != null) _preorder(node.Left);
            Console.WriteLine(node.Item.ToString());
            if (node.Right != null) _preorder(node.Right); 
            
        }
        private void _posorder (AVLNode<T> node)
        {
            if (node.Right != null) _posorder(node.Right);
            Console.WriteLine(node.Item.ToString());
            if (node.Left != null) _posorder(node.Left); 
        }

        private void _inorder (AVLNode<T> node )
        {
            Console.WriteLine(node.Item.ToString());
            if (node.Left != null) _inorder(node.Left);
            if (node.Right != null) _inorder(node.Right); 
        }
    }
}
