using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrade
{
    class Human
    {
        /// <summary>
        /// 问候
        /// 
        /// </summary>
        /// <param name="language">语言</param>
        /// <param name="name">名字</param>
        public void Greeting(string language,string name)
        {
            switch (language)
            { 
                case "zh-cn":
                    ChineseGreeting(name);
                    break;
                case "en-us":
                    EnglishGreeting(name);
                    break;
                default:
                    EnglishGreeting(name);
                    break;
            }
        }
        public void EnglishGreeting(string name)
        {
            Console.WriteLine("Hello,{0}!",name.ToString());
        }
        public void ChineseGreeting(string name)
        {
            Console.WriteLine("你好,{0}！",name.ToString());
        }
    }
}
