using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree<T> : ICollection<T>, IEnumerable<T> where T : IComparable<T>
    {
        
        private Node<T> head;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (head == null)
                head = new Node<T>(item);
            else
                Insert(item);
        }
        private IEnumerable<Node<T>> InOrderDepthTraversal(Node<T> node)
        {
            if (node.left != null)
            {
                foreach (Node<T> leftNode in InOrderDepthTraversal(node.left))
                    yield return leftNode;
            }
            yield return node;
            if (node.right != null)
            {
                foreach (Node<T> rightNode in InOrderDepthTraversal(node.right))
                    yield return rightNode;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (Node<T> temp in InOrderDepthTraversal(head))
            {
                yield return temp.value;
            }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Node<T> temp in InOrderDepthTraversal(head))
            {
                yield return temp.value;
            }
        }

        private void Insert(T item)
        {
            Node<T> TempNode = head;
            while (true)
            {
                int ComparedValue = TempNode.value.CompareTo(item);
                if (ComparedValue < 0)
                {
                    if (TempNode.left == null)
                    {
                        TempNode.left = new Node<T>(item, TempNode);
                        return;
                    }
                    else
                    {
                        TempNode = TempNode.left;
                    }
                }
                else if (ComparedValue > 0)
                {
                    if (TempNode.right == null)
                    {
                        TempNode.right = new Node<T>(item, TempNode);
                        return;
                    }
                    else
                    {
                        TempNode = TempNode.right;
                    }
                }
                else
                {
                    TempNode = TempNode.right;
                }
            }
        }




    }
}
