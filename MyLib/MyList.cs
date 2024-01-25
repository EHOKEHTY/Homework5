using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MyList
    {
        private object[] items;

        public int Count { get; private set; }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public MyList()
        {
            items = new object[1];
            Count = 0;
        }

        public void Add(object toAdd)
        {
            IncreaseCapacity();
            items[Count] = toAdd;
            Count++;
        }

        public void Insert(int index, object toInsert)
        {
            if (index > items.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                object[] o = items;
                IncreaseCapacity();
                for (int i = 0; i < index; i++)
                {
                    items[i] = o[i];
                }

                items[index] = toInsert;

                for (int i = index + 1; i < items.Length; i++)
                {
                    items[i] = o[i - 1];
                }
                Count++;
            }
        }

        public void Remove(object obj)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(obj))
                {
                    RemoveAt(i);
                }
            }
        }

        public void RemoveAt(int index)
        {
            object[] o = new object[Count];

            for (int i = 0; i < Count; i++)
            {
                o[i] = items[i];
            }

            items = new object[items.Length - 1];

            for (int i = 0, j = 0; i < items.Length && j < items.Length; i++, j++)
            {
                if (i == index)
                {
                    i++;
                }
                items[j] = o[i];
            }
        }

        public void Clear()
        {
            Count = 0;
            items = new object[0];
        }

        public bool Contains(object obj)
        {

            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(obj))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(obj))
                {
                    return i;
                }
            }
            return -1;
        }

        public object[] ToArray()
        {
            object[] array = new object[Count];
            for (int i = 0; i < Count; i++)
            {
                array[i] = items[i];
            }
            return array;
        }

        public void Reverse()
        {
            for (int i = 0, j = Count; i < Count / 2; i++, j--)
            {
                (items[i], items[j]) = (items[j], items[i]);
            }
        }

        public void Display()
        {
            Console.WriteLine(string.Join(", ", items));
        }

        private void IncreaseCapacity()
        {
            if (Count + 1 > items.Length)
            {
                object[] temp = new object[items.Length + 1];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }
        }
    }
}
