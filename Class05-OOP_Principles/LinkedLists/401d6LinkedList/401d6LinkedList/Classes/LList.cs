namespace _401d6LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        //public LList(Node node)
        //{
        //    Head = node;
        //}

        public void Insert(int value)
        {
            Node silly = new Node(value);
            silly.Next = Head;
            Head = silly;
        }

        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            // output to the console the linked list
        }


    }
}
