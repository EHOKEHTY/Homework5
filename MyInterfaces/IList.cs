using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces
{
    public interface IList<T> : ICollection
    {
        T this[int index] { get; set; }
        void Add(T toAdd);
        void Insert(int index, T toInsert);
        void Remove(T obj);
        void RemoveAt(int index);
        bool Contains(T obj);
        int IndexOf(T obj);
        T[] ToArray();
        void Reverse();
        void Display();
    }
}
