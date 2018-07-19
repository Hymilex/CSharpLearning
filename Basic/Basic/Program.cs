using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
            Console.Read();
        }

        static void test()
        {
            Person p1 = new Person();
            Person p2 = new Person("I'M PANJINLIAN.");
            Person p3 = Person.GetPerson();
            

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p3.Name);

            Person p4 = new Person();
            p4[0] = "hello";
            p4[1] = " ";
            p4[2] = "world";
            Console.WriteLine(p4[0]+" "+p4[2]);

            Horse hrs1 = new Horse();
            hrs1.Age = 2;

            Horse hrs2 = new Horse(666);
            hrs2.Age = 3;

            Animal hrs3 = new Horse(1);
            hrs3.Voice();

            Horse hrs4 = new Horse(5);
            hrs4.Voice();
        }
    }
}
