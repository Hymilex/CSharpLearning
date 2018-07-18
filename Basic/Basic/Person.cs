using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    /// <summary>
    /// Person pratice
    /// </summary>
    class Person
    {
        public string name;
        private int age;
        //静态成员
        public static Person ps;

        //10个人
        private string[] psn = new string[4];
        //表示索引器，可以像访问数组一样访问类中的数组成员
        public string this[int index]
        {
            get
            {
                return psn[index];
            }
            set
            {
                psn[index] = value;
            }
        }

        //get & set another way to implent.
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 120)
                { 
                    throw(new ArgumentOutOfRangeException("AgeIntProperty",value,"Age has its own range."));
                    //age = value;
                }
                age = value;
            }
        }

        //get & set 访问器
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Person()
        {
            name = "Learning C sharp Hard!";
        }

        //重载构造函数
        public Person( string name )
        {
            this.name = name;
        }
        //私有构造函数只能在类定义时被实例化
        private Person(string px1,string px2)
        {
            Console.WriteLine("Private contructor function would be invoked.");
            this.name = "Private,"+px1+','+px2+"!";
        }
        //静态方法用于返回类的实例
        public static Person GetPerson()
        {
            ps = new Person("Joseph","Simon");
            return ps;
        }

        ~Person()
        {
            Console.WriteLine("DestroyFunction has been invoked.");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 结构体和类之间:
    /// 1.结构体中的每个成员都要在构造函数中进行定义
    /// 2.结构体和类是值类型和引用类型
    /// </summary>
    struct Point
    {
        private int X;
        private int Y;
        public Point(int x ,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
