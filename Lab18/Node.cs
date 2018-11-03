namespace Lab18
{
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
