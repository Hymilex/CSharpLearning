using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrade
{
    public class Friend
    {
        //字段
        public string Name;
        //构造器
        public Friend(string name)
        { 
            this.Name = name;
        }
        //事件处理函数
        public void SendMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine(this.Name + " has received,i gonna participate in it on time. ");
        }
    }
}
