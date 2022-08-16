﻿using System;
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
    }
}
