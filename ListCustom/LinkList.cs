using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCustom
{
    public class LinkList
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
            }



        }
    }

    
}
