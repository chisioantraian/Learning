using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{

    class BinarySearchTree
    {
        private class Node 
        {
            internal int Data;
            internal Node? Left;
            internal Node? Right;

            public Node(int data)
            {
                Data = data;
            }
        }

        private Node? root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int value)
        {
            Node node = new Node(value);
            if (root is null)
            {
                root = node;
                return;
            }

            Node? current = root;

            while (current is not null)
            {
                Node? parent = current;
                if (value < current.Data)
                {
                    current = current.Left;
                    if (current is null)
                        parent.Left = node;
                }
                else if (value > current.Data)
                {
                    current = current.Right;
                    if (current is null)
                        parent.Right = node;
                }
            }
        }

        public void InsertRec(int value)
        {
            root = InsertRec(root, value);
        }

        private Node InsertRec(Node? root, int value)
        {
            if (root is null)
            {
                return new Node(value);
            }

            if (value < root.Data)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value > root.Data)
            {
                root.Right = InsertRec(root.Right, value);
            }
            return root;
        }

        public void PreOrderDisplay()
        {
            PreOrder(root);

            void PreOrder(Node? root)
            {
                if (root != null)
                {
                    Console.Write(root.Data + " ");
                    PreOrder(root.Left);
                    PreOrder(root.Right);
                }
            }
        }

        public void InOrderDisplay()
        {
            InOrder(root);

            void InOrder(Node? root)
            {
                if (root != null)
                {
                    InOrder(root.Left);
                    Console.Write(root.Data + " ");
                    InOrder(root.Right);
                }
            }
        }

        public void PostOrderDisplay()
        {
            PostOrder(root);

            void PostOrder(Node? root)
            {
                if (root != null)
                {
                    PostOrder(root.Left);
                    PostOrder(root.Right);
                    Console.Write(root.Data + " ");
                }
            }
        }



        /*public IEnumerable<int> GenerateInorder()
        {
            return GenerateInorder(root);
        }

        private IEnumerable<int> GenerateInorder(Node? node)
        {
            if (node != null)
            {
                foreach (int i in GenerateInorder(node.Left))
                    yield return i;

                yield return node.Data;

                foreach (int i in GenerateInorder(node.Right))
                    yield return i;
            }
        }*/

    }
}
