using System.ComponentModel;
using MyLib;
namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Insert(8, 's');
            list.Remove(8);
            list.Display();

            var tree = new MyBinaryTree();
            tree.Add(1);
            tree.Add(30);
            tree.Add(15);
            tree.Add(17);
            tree.Add(8);
            tree.Add(40);
            tree.Add(41);
            tree.Add(4);

            Console.WriteLine(tree.Contains(8));
            int[] a = tree.ToArray();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}