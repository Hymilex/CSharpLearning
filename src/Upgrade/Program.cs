using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrade
{
    /// <summary>
    ///1. 委托可以理解为函数的一个包装，使c#中的函数可以作为参数来进行传递，相当于C++中的函数指针。
    ///2.委托限制:
    ///  a、方法的签名必须和委托一致，方法签名包括参数个数、类型和顺序
    ///  b、方法的返回类型要和委托一致，方法的返回类型不属于方法签名的一部分喔。
    ///  
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            test(); 
        }

        static void test()
        {
            DelegationTest dt = new DelegationTest();
            dt.ExcDelegation();
            dt.ExcLang();

            BrideGroom bridegroom = new BrideGroom();

            Friend frd1 = new Friend("Jack");
            Friend frd2 = new Friend("Simon");
            Friend frd3 = new Friend("Joseph");

            //使用+=来订阅事件
            bridegroom.MarryEvent += new BrideGroom.MarryHandler(frd1.SendMessage);
            bridegroom.MarryEvent += new BrideGroom.MarryHandler(frd2.SendMessage);

            //发出通知
            bridegroom.OnMarriageComing("Hey,friends!I will get married,and expect your coming!");
            Console.WriteLine("-----------------------------------");

            //使用-=来取消事件
            bridegroom.MarryEvent -= new BrideGroom.MarryHandler(frd2.SendMessage);
            bridegroom.MarryEvent += new BrideGroom.MarryHandler(frd3.SendMessage);
            bridegroom.OnMarriageComing("Hey,friends!I will get married,and expect your coming!");
            Console.Read();

        }


    }
}
