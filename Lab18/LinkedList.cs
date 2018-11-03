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
                if (Head == null)
                {
                    return false;
                }
                var node = GetNode(index);
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
            catch (IndexOutOfRangeException)
            {
                return false;
            }

            return true;
        }

        private void DestroyNode(Node node)
        {
            node.Data = null;
            node.Next = null;
        }

        private void SetHeadAndTail()
        {
            int index = 0;
            Head = GetNode(index);
            Node node = Head.Next;

            do
            {
                node = node.Next;
            } while (node.Next != null);

            Tail = node;
        }
    }
}
