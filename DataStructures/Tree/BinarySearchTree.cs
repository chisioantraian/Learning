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

        public void InsertRec(int value) => root = InsertRec(root, value);

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

        public bool Contains(int value)
        {
            Node? current = root;
            while (current is not null)
            {
                if (current.Data == value)
                {
                    return true;
                }
                else if (current.Data > value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }

        public bool Contains_Rec(int value) => Contains_Rec(root, value);
        private bool Contains_Rec(Node? root, int value)
        {
            if (root is null)
            {
                return false;
            }
            if (root.Data == value)
            {
                return true;
            }
            if (root.Data > value)
            {
                return Contains_Rec(root.Left, value);
            }
            else
            {
                return Contains_Rec(root.Right, value);
            }
        }


        //
        // ----- remove iterative ------
        //
        private (Node?, Node?) FindNodeAndParent(int value)
        {
            Node? parent = null;
            Node? current = this.root;
            while (current is not null && current.Data != value)
            {
                parent = current;
                if (value < current.Data)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return (parent, current);
        }

        private void RemoveWithOneChild(Node current, Node? parent)
        {
            Node? newCurr = (current.Left is null) ? current.Right : current.Left;

            if (parent is null)
            {
                this.root = newCurr;
                return;
            }

            if (current == parent.Left)
                parent.Left = newCurr;
            else
                parent.Right = newCurr;
        }

        private (Node?, Node?) FindInorderSuccesorAndParent(Node current)
        {
            Node? parent = null;
            Node? successor = current.Right;
            while (successor?.Left is not null)
            {
                parent = successor;
                successor = successor.Left;
            }
            return (successor, parent);
        }

        private void RemoveWithTwoChildren(Node current, Node? parent)
        {
            (Node? successor, Node? successorParent) = FindInorderSuccesorAndParent(current);

            if (successorParent is not null)
                successorParent.Left = successor?.Right;
            else
                current.Right = successor?.Right;
            
            if (successor is not null)
                current.Data = successor.Data;
        }

        public void Remove_Iterative(int value)
        {
            (Node? parent, Node? current) = FindNodeAndParent(value);

            if (current is null)
            {
                return;
            }

            if (current.Left is null || current.Right is null) 
            {
                RemoveWithOneChild(current, parent);
            }
            else
            {
                RemoveWithTwoChildren(current, parent);
            }
        }
        //
        // ----------
        //


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
