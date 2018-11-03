using System;

namespace Lab18
{
    public class LinkedList
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }

        public void Add(string userInput)
        {
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }
        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head;
            while (start != index)
            {
                start += 1;
                temp = temp.Next;
            }
            return temp;
        }
        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }
        public bool RemoveAt(int index)
        {
            try
            {
                var node = GetNode(index);
                if (node == null)
                {
                    return false;
                }
                if (node == Head)
                {
                    Head = node.Next;
                }
                else
                {
                    var previousNode = GetNode(index - 1);
                    previousNode.Next = node.Next;
                }

                SetHeadAndTail();
                DestroyNode(node);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool InsertAt(int index, Node node)
        {
            try
            {
                var tempNode = GetNode(index);
                if (tempNode == Head)
                {
                    node.Next = tempNode;
                    Head = node;
                }
                else
                {
                    var previousNode = GetNode(index - 1);
                    node.Next = previousNode.Next;
                    previousNode.Next = node;
                }

                SetHeadAndTail();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public void PrintReverse()
        {
            var index = Count - 1;

            for (int i = Count -1; i >= 0; i--)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }

        private void DestroyNode(Node node)
        {
            node.Data = null;
            node.Next = null;
        }

        private void SetHeadAndTail()
        {
            Count = 1;
            Head = GetNode(0);
            Node node = Head.Next;

            do
            {
                node = node.Next;
                Count++;
            } while (node.Next != null);

            Tail = node;
        }
    }
}
