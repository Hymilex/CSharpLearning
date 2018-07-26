using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExternClass
{
    public static class ListExtern
    {
        //定义扩展方法
        public static int JSum(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("输入数组为空");
            }
            int jsum = 0;
            bool flag = false;
            foreach (int current in source)
            {
                if (!flag)
                {
                    jsum += current;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return jsum;
        }
        public static void Test()
        {
            List<int> source = new List<int>();
            
            Random rdm = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                source.Add(rdm.Next(50));
            }
            int jsum = ListExtern.JSum(source);
            Console.WriteLine("数组的奇数之和是:{0}.", jsum.ToString());
            Thread.Sleep(500);
        }

        //扩展方法第一个参数必须加上this关键字
        public static void Print(this Person per)
        {
            Console.WriteLine("当前命名空间下的扩展方法，姓名为:{0}",per.Name);
        }
    }
}
