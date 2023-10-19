using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public int Count(T comparableItem)
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(comparableItem) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
