using System.ComponentModel;
using MyLib;
namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>
            {
                1,2,3,4,5,6,7,8,9,10
            };
            list.Insert(6, -10);
            list.RemoveAt(6);
            list.Remove(8);

            var tree = new MyBinaryTree<int>
            {
                1,30,15,17,8,40,41,4
            };

            var filtered = list.Where(a => a > 4);
            var filtered2 = tree.Where(a => a <= 15);

            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            foreach (var item in filtered2)
            {
                Console.WriteLine(item);
            }
        }
    }
}