using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        public T value;
        public Node<T> parent;
        public Node<T> left;
        public Node<T> right;

        public Node(T value)
        {
            this.value = value;
        }
        public Node(T value, Node<T> parent)
        {
            this.parent = parent;
            this.value = value;
        }
        public Node()
        {

        }
        public override string ToString()
        {
            return value.ToString();
        }

    }
}
