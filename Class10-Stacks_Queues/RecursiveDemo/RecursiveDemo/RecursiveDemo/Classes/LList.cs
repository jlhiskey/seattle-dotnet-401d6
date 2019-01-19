using System;

namespace RecursiveDemo.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        public bool Includes(int value)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public void Print()
        {
            Node Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} => ");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} => NULL");
        }

        public void RecursivePrint(Node node)
        {
            // What is our base case?
            if (node.Next == null)
            {
                Console.WriteLine(node.Value);
                return;
            }

            Console.WriteLine(node.Value);
            RecursivePrint(node.Next);

        }

        public Node RecursiveFind(int value, Node node)
        {
            if (node.Value == value)
            {
                return node;
            }
            if (node.Next == null)
            {
                return node.Next;
            }
           return RecursiveFind(value, node.Next);
        }

        public Node FindRecursive(int value)
        {
            Node node = FindRecursive(value, Head);
            return node;
        }

        private Node FindRecursive(int value, Node node)
        {
            if (node.Next == null)
            {
                if (value == node.Value)
                {
                    return node;
                }
            }
            if (node.Value == value)
            {
                return node;
            }
            else
            {
                return FindRecursive(value, node.Next);
            }

        }

        public void Append(int value)
        {
            Node node = new Node(value);

            Node current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            // the end of the linked list
            Current.Next = node;

        }
    }
}
