namespace BinaryTree
{
    public class BinaryTree
    {
        private Node root;
        private Node current;
        
        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);

                current = root;

                return;
            }

            while (true)
            {
                if (value < current.Value)
                {
                    if (current.LeftNode == null)
                    {
                        current.LeftNode = new Node(value);
                        return;
                    }

                    current = current.LeftNode;
                }
                else
                {
                    if (current.RightNode == null)
                    {
                        current.RightNode = new Node(value);
                        return;
                    }
                    current = current.RightNode;
                }

            }
        }

        public bool Find(int value)
        {
            if (root == null)
                return false;

            current = root;

            while (true)
            {
                if (value == current.Value)
                {
                    return true;
                }

                if (value < current.Value)
                {
                    if (current.LeftNode == null)
                    {
                        return false;
                    }

                    current = current.LeftNode;
                }
                else
                {
                    if (current.RightNode == null)
                    {
                        return false;
                    }

                    current = current.RightNode;
                }
                

            }
        }

    }
}