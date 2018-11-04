using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class Frequency
    {
        public Dictionary<int, int> Items { get; set; }

        public int[] Array { get; set; }

        public int[] FrequencyArray { get; set; }

        public Frequency(int[] array)
        {
            Array = array;
            Items = new Dictionary<int, int>();
        }

        public void FindFrequency()
        {
            foreach (var item in Array)
            {
                if (Items.ContainsKey(item))
                {
                    Items[item]++;
                }
                else
                {
                    Items.Add(item, 1);
                }
            }
        }

        public void FindFrequencyWithArray()
        {
            FrequencyArray = new int[Array.Max() + 1];
            foreach (var item in Array)
            {
                FrequencyArray[item]++;
            }
        }

        public void DisplayFrequency()
        {
            foreach (var item in Items.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine();
        }

        public void DisplayFrequencyArray()
        {
            for (int i = 0; i < FrequencyArray.Length; i++)
            {
                if (FrequencyArray[i] > 0)
                {
                    Console.WriteLine($"{i}: {FrequencyArray[i]}");
                }
            }

            Console.WriteLine();
        }
    }
}
