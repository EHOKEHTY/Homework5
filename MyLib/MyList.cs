using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInterfaces;
namespace MyLib
{
    public class MyList<T> : MyInterfaces.IList<T>
    {
        private T[] items;

        public int Count { get; private set; }

        public T this[int index]
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
            items = new T[0];
            Count = 0;
        }

        public void Add(T toAdd)
        {
            IncreaseCapacity();
            items[Count] = toAdd;
            Count++;
        }

        public void Insert(int index, T toInsert)
        {
            if (index > items.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T[] o = items;
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

        public void Remove(T obj)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(obj))
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            T[] o = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                o[i] = items[i];
            }

            items = new T[items.Length - 1];
            Count--;

            for (int i = 0, j = 0; i <= items.Length; i++, j++)
            {
                if (i == index)
                {
                    i++;
                }
                if (i >= o.Length)
                {
                    break;
                }
                items[j] = o[i];
                
            }

        }

        public void Clear()
        {
            Count = 0;
            items = new T[0];
        }

        public bool Contains(T obj)
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

        public int IndexOf(T obj)
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

        public T[] ToArray()
        {
            T[] array = new T[Count];
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
                T[] temp = new T[items.Length + 1];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }
        }
    }
}
