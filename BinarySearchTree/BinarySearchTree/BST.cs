using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST<T>
    {
        private class Node<E>
        {
            Node<E> left { get; set; }
            Node<E> right { get; set; }
            E data { get; set; }

            public Node(E d)
            {
                data = d;
                left = null;
                right = null;
            }
        }

        public void Add(T data)
        {

        }

        public void AddArray(T[] data)
        {

        }

        public T[] ReturnInOrderArray()
        {
            return null;
        }

        public T[] ReturnPreOrderArray()
        {
            return null;
        }

        public T[] ReturnPostOrderArray()
        {
            return null;
        }
    }
}
