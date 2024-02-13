using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces
{
    public interface IList : ICollection
    {
        object this[int index] { get; set; }
        void Add(object toAdd);
        void Insert(int index, object toInsert);
        void Remove(object obj);
        void RemoveAt(int index);
        bool Contains(object obj);
        int IndexOf(object obj);
        object[] ToArray();
        void Reverse();
        void Display();
    }
}
