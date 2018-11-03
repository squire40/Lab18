namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();

            l.Add("Dave");
            l.Add("Shark");
            l.Add("Coco");
            l.Add("Sylvia");

            var result = l.RemoveAt(5);

            l = null;
        }
    }
}
