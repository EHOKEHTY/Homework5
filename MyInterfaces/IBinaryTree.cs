using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces
{
    public interface IBinaryTree<T> : ICollection where T : IComparable<T>
    {
        void Add(T value);
        bool Contains(T value);
        T[] ToArray();
    }
}
