using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    class Three
    {
        //可空类型  int? 可空变量 int 非可空变量
        public static void NullOption()
        {
            int? nullx = null;
            int? nully = 12;
            // 空合并操作符 ??
            int cmp = nullx ?? (int)nully;
            Console.WriteLine("cmp is {0}.",cmp.ToString()); //c#2.0中简化代码
        }
        //匿名方法和委托有这密切的关系
        delegate void VoteDelegate(string name);

        public static void ExecPig()
        {
            VoteDelegate vdl;
            vdl = new VoteDelegate(Three.Pig);
            vdl("八戒");
            Console.ReadKey();


            //匿名方法的使用,换句话说就是将原来要写的方法直接写在一起
            VoteDelegate vdl2 = delegate(string tickname)
                {
                    Console.WriteLine("{0}不是猪.", tickname);
                };
            vdl2("天蓬元帅");
            Console.ReadKey();
        }

        public static void Pig(string name)
        {
            Console.WriteLine("猪叫{0}!",name);
        }



        //迭代器
        public static void UsageDD()
        {
            Peppis ps = new Peppis();
            foreach(Peppi p in ps)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine(new string('*',5));
            Console.ReadKey();
        }
    }

}
