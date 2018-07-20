using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeEmbeded
{
    class Enchase
    {
        /// <summary>
        /// 1.内存分配
        /// 2.完成实际数据的复制
        /// 3.地址的返回
        /// </summary>
        public object ECH(int j)
        {
            int i = j;
            //装箱操作
            object o = i;

            return o;
        }
        /// <summary>
        /// 1.检查拆箱的引用类型是否为空，如果是如果是，则返回NullRefenceException
        /// 接着检查变量是否和拆箱后的类型属于同类型，如果不是，会导致InvalidCastException
        /// 2.地址返回
        /// 3.数据复制：将托管堆上数据复制到线程栈上
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Devanning(object o)
        {
            //强制拆箱
            int j = (int)o;
            return j;
        }
    }
}
