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

        private Node? root = null;


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


        public void InsertCool(int value) => InsertCool(ref root, value);

        private void InsertCool(ref Node? root, int value)
        {
            if (root is null)
            {
                root = new Node(value);
            }
            else if (value < root.Data)
            {
                InsertCool(ref root.Left, value);
            }
            else if (value > root.Data)
            {
                InsertCool(ref root.Right, value);
            }
        }

        public void PreOrderDisplay() => PreOrder(root);
        private void PreOrder(Node? root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }


        public void InOrderDisplay() => InOrder(root);
        private void InOrder(Node? root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.Write(root.Data + " ");
                InOrder(root.Right);
            }
        }

        public void PostOrderDisplay() => PostOrder(root);
        private void PostOrder(Node? root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.Write(root.Data + " ");
            }
        }

    }
}
