using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTips
{
    class OptionParams
    {
        public static void TestMethod(int x,int y =10, string name = "simon")
        {
            Console.WriteLine("x={0},y={1},name = {2}",x,y,name);
        }
        /// <summary>
        /// 1.可选参数必须在必选参数之后
        /// 2.用ref & out 关键字不能被设置为可选参数
        /// 3.参数数组不可以被设置为可选参数
        /// </summary>
        public static void InvokeMethod()
        {
            TestMethod(2,3,"Joseph");
            TestMethod(21,3);
            TestMethod(34);
            //实参指定名称
            TestMethod(x:56,name:"Mike",y:99);
        }
    }
}
