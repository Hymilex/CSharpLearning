using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeEmbeded
{
    public class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
        public static void GTest()
        {
            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine("{0}",i.GetType().Name);
            char p = MyClass<char>.FactoryMethod();
            Console.WriteLine(p.GetType().Name);
        }
    }
}
