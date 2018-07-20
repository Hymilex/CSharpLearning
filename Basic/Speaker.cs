using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    /// <summary>
    /// 1.显式实现的成员默认是私有的 所以这些成员不能直接去访问
    /// 2.正确方式应该将其转换为对应的接口对其进行实现
    /// 
    /// *********************接口和抽象类的区别*******************
    /// 1.抽象类使用的是abstract 关键字对其进行定义,而接口使用的是interface，都不能实例
    /// 2.抽象类不能实现多继承，接口可以
    /// 3.抽象类是对一类的抽象，继承与于抽象类的类与抽象类是属于的关系。实现接口的类表明类具有接口声明的方法。
    /// ******************Why Abstract?**************************
    /// 1.由于发现各个子对象之前存在共性
    /// 2.达到代码重用的效果
    /// </summary>
    class Speaker : IAmericaGreeting,IChineseGreeting
    {
        /*
        public void SayHello()
        {
            Console.WriteLine("Hello vs Hi.");
        }
         */
        void IChineseGreeting.SayHello()
        {
            Console.WriteLine("你好!");
        }
        void IAmericaGreeting.SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
