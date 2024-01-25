namespace ClassLibrary
{
    class s
    {
        private object[] items;
        public int Count { get; private set; }
        private int capacity;

        public s()
        {
            Count = 0;
            capacity = 1;
            items = new object[capacity];
        }

        public s(int capacity)
        {
            Count = 0;
            this.capacity = capacity;
            items = new object[capacity];
        }

        public void Add(object toAdd)
        {
            items[Count] = toAdd;
            IncreaseCapacity();
        }

        public void Insert(int index, object toInsert)
        {
            IncreaseCapacity();
            object[] o = items;

            // я записываю всё в темповый массив,
            // увеличиваю основной массив,
            // записываю часть массива(из темпового в основной) до индекса,
            // ??????
            // увеличиваю ёмкость родного массива (нью обжект [капасити + 1])
            // Перезаписываю данные до индекса,
            // записываю индекс,
            // дозаписываю данные


            for (int i = 0; i < index; i++)
            {
                items[i] = o[i];
            }

            items[index] = toInsert;

            for (int i = index + 1; i < capacity; i++)
            {
                items[i] = o[i - 1];
            }

            //if (index > 0 && index < Count)
            //{
            //    IncreaseCapacity();
            //    Array.Copy(items, index, items, index + 1, Count - index);
            //    items[index] = toInsert;
            //}
            //else if (index == (Count + 1))
            //{
            //    Add(toInsert);
            //}
        }

        public void Remove(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(obj))
                {
                    RemoveAt(i);
                }
            }
        }

        public int IndexOf(object obj)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(obj))// хуйня?
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            Array.Copy(items, index, items, index - 1, Count - index);  // хуйня
            items[Count--] = null;
        }

        public void Reverse()
        {
            int j = Count;
            object temp;
            for (int i = 0; i < Count / 2; i++, j--)
            {
                (items[i], items[j]) = (items[j], items[i]);
            }
        }

        public void Display()
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
            }
        }

        public void Clear()
        {
            capacity = 1;
            Count = 0;
            items = new object[capacity];
        }

        public bool Contains(object obj)
        {

            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(obj))   // хуйня
                {
                    return true;
                }
            }
            return false;
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

        private void IncreaseCapacity() // хуйня?
        {
            Count++;
            if (Count >= capacity)
            {
                capacity++;
                object[] o = new object[capacity];
                for (int i = 0; i < capacity - 1; i++)
                {
                    o[i] = items[i];
                }
                items = o;
            }
        }
    }

    class MyBinaryTree
    {

    }
}

