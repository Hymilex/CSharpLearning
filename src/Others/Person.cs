using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
        public Person()
        { }

        public static void TPS()
        {
            Person p = new Person { Name = "simon", Age = 12, Height = 120, Weight = 60 };
            Person p1 = new Person() { Name = "Joseph",Age=20,Height=180,Weight=62};

            //集合初始化器
            List<string> newnames = new List<string> { 
            "DPL",
            "PYTHON",
            "MACHINE LEARNING"
            };

            //匿名数组
            var personcollection = new[] {
            new {Name="JOSEPH",Age=12,Height=180,Weight=60},
            new {Name="Mike",Age=63,Height=180,Weight=70}
            };
            Console.WriteLine(personcollection.GetType().Name.ToString()+","+personcollection[0].Name);

            Console.Read();
        }
    }
}
