using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class AVLNode<T> where T: IComparable<T>
    {
        T _item { get; set; }
        AVLNode<T> _left { get; set; } = null;
        AVLNode<T> _right { get; set; } = null;
        int _heigth { get; set; } = 0;

        public AVLNode(T item)
        {
            this._item = item;
            this._left = null;
            this._right = null;
            this._heigth = 0; 
        }

        public T Item { get => this.Item; }

        public int Height { 
            get 
            {
                int height_left = this._left == null ? 0: this._left.Height ;
                int height_right = this._right == null ? 0 : this._right.Height;
                return height_right - height_left;               
            } 
        }
    }
}
