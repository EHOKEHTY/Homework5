using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces
{
    public interface IBinaryTree : ICollection
    {
        void Add(int value);
        bool Contains(int value);
        int[] ToArray();
    }
}
