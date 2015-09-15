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
}
