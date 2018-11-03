using System.Diagnostics;

namespace Lab18
{
    [DebuggerDisplay("{Data}")]
    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data, Node next)
        {
            Data = data;
            Next = next;
        }
        public Node()
        {

        }
    }
}
