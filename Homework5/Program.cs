using System.ComponentModel;
using MyLib;
namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object []items = new object[8];
            //items[0] = 'f';
            //items[1] = 'w';
            //items[2] = 3;
            //items[3] = 32;

            //object []o = new object[4];

            //o = items;
            //for (int i = 0; i < o.Length; i++)
            //{
            //    //Console.WriteLine(o[i].ToString());
            //    if (o[i] == null)
            //    {
            //        Console.WriteLine("null");
            //    }
            //    else
            //    {
            //        Console.WriteLine(o[i]);
            //    }
            //}
            //MyList list = new MyList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            ////list.Insert(0, "sd");
            ////list.RemoveAt(2);
            //list.Display();
            //Console.WriteLine(list.Contains(3));


            MyList j = new MyList();
            j.Add(1);
            j.Add(2);
            j.Add(3);
            j.Add(4);
            j.Add(5);
            j.Add(6);
            j.Add(7);
            j.Add(8);
            j.Insert(8, 's');
            j.Remove(8);
            j.Display();
            //Console.WriteLine(j[2]);
            //Console.WriteLine(j.Contains('s'));
            //Console.WriteLine(j.IndexOf('s'));
        }
    }
}