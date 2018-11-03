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

        public void DisplayFrequency()
        {
            foreach (var item in Items.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
