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

            l.InsertAt(2, new Node("Grandpa", null));

            l.PrintList();
            //l.PrintReverse();

            Console.ReadKey();

            l.RemoveAt(2);

            l.PrintList();
            //l.PrintReverse();

            Console.ReadKey();

            var ints = new[] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10};

            var f = new Frequency(ints);

            f.FindFrequency();

            f.DisplayFrequency();

            Console.ReadKey();

            f.FindFrequencyWithArray();

            f.DisplayFrequencyArray();

            Console.WriteLine("Big O is O(N)");

            Console.ReadKey();
        }
    }
}
