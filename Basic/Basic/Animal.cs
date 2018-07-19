using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    //Base Class
    public class Animal
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 10)
                { 
                    throw(new ArgumentOutOfRangeException("AgeIntProperty",value,"年龄必须在0-10之间！"));
                }
                age = value;
            }
        }
        //执行顺序是先执行父类再执行子类
        public Animal()
        {
            Console.WriteLine("I'm a base class which was instanced.");
        }

        /// <summary>
        /// 在基类中对通用方法进行虚写，在子类中使用override可以对其进行重载
        /// </summary>
        public virtual void Voice()
        {
            Console.WriteLine();
        }
        //abstract的类为抽象类，抽象类不可以被直接实例化。
    }
}
