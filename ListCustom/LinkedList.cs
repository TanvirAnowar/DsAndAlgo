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

        public bool Contains(int itemValue)
        {
            var current = FirstNode;

            while (current != null)
            {
                if (current.GetValue() == itemValue)
                {
                    return true;
                }
                else
                {
                    current = current.GetNextNode();
                }
            }
            return false;

            // return IndexOf(itemValue) != -1;
        }

        public void RemoveFirst()
        {
            if(FirstNode == null)
                throw new Exception();

            // For only one item in the list
            if (FirstNode == LastNode)
            {
                FirstNode = LastNode = null;
            }

            var secondNode = FirstNode.GetNextNode();
            FirstNode.SetNextNode(null);

            FirstNode = secondNode;
        }

        public void RemoveLast()
        {
            if (FirstNode == null)
                throw new Exception();

            if (FirstNode == LastNode)
            {
                FirstNode = LastNode = null;
            }
            else
            {
                var secondLastNode = getSecondLastNode(LastNode);
                LastNode = secondLastNode;
                LastNode.SetNextNode(null);
            }

        }

        private Node getSecondLastNode(Node lastNode)
        {
            var currentNode = FirstNode;

            while (currentNode.GetNextNode() != null)
            {
                if (currentNode.GetNextNode() == lastNode)
                {
                    return currentNode;
                }
                else
                {
                    currentNode.SetNextNode(currentNode.GetNextNode());
                }

            }

            return null;

        }



    }

    
}
