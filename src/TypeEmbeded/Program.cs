using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeEmbeded
{
    static class Program
    {
        static void Main(string[] args)
        {
            XTest();
        }
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
        public static void XTest()
        {
            Console.WriteLine("Enter lsit size:");
            string str = Console.ReadLine();
            int u = String.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);
            var list = new MyList<int>();
            var t = new Random();
            for (int index = 0; index < u; index++)
            {
                list.Add(t.Next(100));
            }
            Console.WriteLine("Elements of list are:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*',30));
            Console.WriteLine("Enter searching nummber:");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("List contains this nummber.");
            }
            else
            {
                Console.WriteLine("No matches.");
            }

            var arr = GetArray<int>(list);
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
