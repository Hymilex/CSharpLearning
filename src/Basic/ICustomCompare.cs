using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    /// <summary>
    /// 1.在接口中除了定义方法外，还可以包含属性，事件、索引器或者这4类的任意组合。
    /// 2.接口不能包含字段、运算符的重载、实例构造函数和析构函数。
    /// 3.不能使用static
    /// </summary>
    interface ICustomCompare
    {
        // definition to the interface.
        int CompareTo(object other);
    }
}
