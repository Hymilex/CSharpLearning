using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTips
{
    /// <summary>
    /// 1.协变性:从派生类转换为基类，引入out标记泛型参数 以表示支持协变
    /// 2.逆变性:指的是泛型类型参数从一个基类隐式转换为派生类。
    /// c#4.0 引入 in 关键字标记泛型参数
    /// </summary>
    class Convariant
    {
        public static void ConTest()
        {
            List<object> listobj = new List<object>();
            List<string> liststr = new List<string>();
            
            //AddRange 接受参数为 IEnumerable <out T>
            listobj.AddRange(liststr);
        }
        public static void Inverse()
        {
            List<object> listobj = new List<object>();
            List<string> liststr = new List<string>();
            //实例化接口为具体类
            IComparer<object> objComparer = new Testcomparer();
            IComparer<string> strComparer = new Testcomparer();
            // IComparer < in T >   
            liststr.Sort(strComparer);
        }
       
    }
}
