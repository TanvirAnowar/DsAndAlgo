using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustom
{
    public class LinkedList
    {
        private class Node
        {
            private int Value { get; set; }
            private Node NextNode { get; set; }

            public Node(int value)
            {
                Value = value;
            }

            public void SetNextNode(Node currentNode)
            {
                NextNode = currentNode;
            }

            public int GetValue()
            {
                return Value;
            }

            public Node GetNextNode()
            {
                return NextNode;
            }

        }

        private Node FirstNode { get; set; }
        private Node LastNode { get; set; }

        public void Add(int item)
        {
            var itemNode = new Node(item);

            if (FirstNode == null)
            {
                FirstNode = itemNode;
                LastNode = itemNode;
            }
            else 
            {
                LastNode.SetNextNode(itemNode);
                LastNode = itemNode;
            }
        }

        public void AddFirst(int item)
        {
            var currentNode = new Node(item);

            if (FirstNode == null)
            {
                FirstNode = LastNode = currentNode;
            }
            else
            {
                FirstNode.SetNextNode(currentNode);
                FirstNode = currentNode;
            }
        }

        public int IndexOf(int itemValue)
        {
            var index = 0;
            var current = FirstNode;

            while (current != null)
            {
                if (current.GetValue() == itemValue)
                {
                    return index;
                }
                else
                {
                    index++;
                    current = current.GetNextNode();
                }
            }

            return -1;

        }
    }

    
}
