using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeEmbeded
{
    /*
     * 在定义泛型时，有以下几种约束:
     * 1.引用类型的约束:确保传递的实参是引用类型。可以是任何类、接口、委托、数组，但是不能是System.Object          * Steam.Array、System.Delegate、System.MulticastDelegate、System.ValueType、System.Enum和              * System.Void
     * 2.值类型约束
     * 3.构造函数类型约束是T:new()，如果此类型参数为多个约束，这个约束必须最后指定。结构体约束和
     * 4.转换类型约束 表示形式为:
     *  a、T:基类名 确保指定实参必须是基类或者是派生基类的子类
     *  b、T：接口名 确保实参是接口或者实现了接口的类
     *  c、T:U 前面一个类型实参必须是后面类型实参或者后面类型实参的子类
     *  5.组合约束
     * */
    public class Genericity<T> where T:IComparable<T>
    {
        public static T MAX(T obj1, T obj2)
        {
            if (obj1.CompareTo(obj2) > 0)
            {
                return obj1;
            }
            return obj2;
        }
    }
}
