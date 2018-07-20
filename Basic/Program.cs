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

            //Customer Interface practice.
            Customer cst1 = new Customer(12);
            Customer cst2 = new Customer(23);
            if (cst1.CompareTo(cst2)<0)
            {
                Console.WriteLine("{0}比{1}小。",cst1.Age.ToString(),cst2.Age.ToString());
            }
            else if (cst1.CompareTo(cst2) > 0)
            {
                Console.WriteLine("{0}比{1}大。", cst1.Age.ToString(), cst2.Age.ToString());
            }
            else
            {
                Console.WriteLine("一样大。");
            }
            
            //隐式接口不管哪个接口实现的方法都是相同的，但并不是我们期望的结果


            //显式
            Speaker spk = new Speaker();
            IChineseGreeting icg = (IChineseGreeting)spk;
            icg.SayHello();

            IAmericaGreeting iag = (IAmericaGreeting)spk;
            iag.SayHello();


            Console.ReadKey();

        }
    }
}
