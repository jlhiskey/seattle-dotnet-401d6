using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueusDemo.Classes
{
    class Stack
    {
        // Top Reference so we know where the top is
        public Node Top { get; set; }


        //Give us a stack with at least one node in it.
        public Stack(Node node)
        {
            Top = node;
        }

        // Give us an empty stack
        public Stack()
        {

        }
        // push
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        // pop
        public Node Pop()
        {
            // create a temp
            Node temp = Top;
            //set top to the next node in the stack
            Top = Top.Next;
            // clear the reference of next on the temp
            temp.Next = null;
            // return the node
            return temp;
        }


        // peek

        public Node Peek()
        {
            // Show us the top node of a stack
            return Top;
        }
    }
}
