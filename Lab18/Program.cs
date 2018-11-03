using System;

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
            l.Add("Mama");

            l.PrintList();

            //l.PrintReverse();

            Console.ReadKey();

            l.InsertAt(5, new Node("Grandpa", null));

            l.PrintList();
            //l.PrintReverse();

            Console.ReadKey();

            l.RemoveAt(5);

            l.PrintList();
            //l.PrintReverse();

            Console.ReadKey();

            var ints = new[] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10};

            var f = new Frequency(ints);

            f.FindFrequency();

            f.DisplayFrequency();

            f.FindFrequencyWithArray();

            f.DisplayFrequency();

            Console.WriteLine("Big O is O(N)");

            Console.ReadKey();
        }
    }
}
