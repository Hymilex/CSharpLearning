using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Upgrade
{
    /// <summary>
    ///  1.事件和委托是c#1.0最经典的两个属性
    ///  2.方式: 访问修饰符 event 委托类型 事件名
    ///  3.订阅与取消:
    ///    a、+= 订阅事件
    ///    b、-= 取消订阅
    /// </summary>
    
    public class BrideGroom
    {
        //新郎官充当事件的发布者
        public delegate void MarryHandler(string msg);

        //使用自定义委托类型定义事件,事件名为MarryEvent
        public event MarryHandler MarryEvent;

        //发出事件
        public void OnMarriageComing(string msg)
        { 
            //判断是否绑定了事件的处理方法
            if (MarryEvent != null)
            {
                MarryEvent(msg);
            }
        }

    }
}
