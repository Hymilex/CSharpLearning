using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrade
{
    /// <summary>
    /// 1.委托最大的作用就是使一个方法可以作为另一个方法的参数进行传递。
    /// 
    /// 2.委托链就是将所有的委托叠加起来一起调用。
    /// 
    /// 3.参考符: += -=
    /// 
    /// 4.静态和动态方法都可以对其进行委托，静态是不需要实例化的。
    /// </summary>
    class DelegationTest
    {
        //1.定义委托类型
        delegate void MyDelegate(int parm1, int parm2);
        public void ExcDelegation()
        { 
            //2.声明委托变量
            MyDelegate md;
            //3.实例化委托变量
            md = new MyDelegate(new DelegationTest().Plus);

            //4.委托类型作为参数传给另一个方法
            MyMethod(md);
            //Console.Read();

        }

        //该方法的定义必须与委托定义相同
        public void Plus(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("{0}+{1}={2}！",a.ToString(),b.ToString(),sum.ToString());
            Console.ReadKey();
        }

       
        static void MyMethod(MyDelegate mdt)
        {
            //5.在方法中调用委托
            mdt(1,2);
            //mdt.Invoke(1,2);
        }

        //1.声明委托
        delegate void GreetingDelegation(string lang,string name);

        public void ExcLang()
        {
            //2.定义委托
            GreetingDelegation gd;
            //3.实例化委托
            gd = new GreetingDelegation(new Human().Greeting);

            //4.将委托传给另一个方法
            gd("zh-cn","simon");
            //MyGreeting(gd);
        }

        //所谓定义的另一个方法
        static void MyGreeting(GreetingDelegation GDL)
        {
            GDL("en-us","black-giser");
            Console.Read();
        }
    }
}
