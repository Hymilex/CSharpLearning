using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq查询Collection
            LO.ExecLinq();
            //Linq查询XML
            LO.ExecXML();

            //工作者线程最大数目，I/O线程的最大数目
            ThreadPool.SetMaxThreads(1000, 1000);
            //启动工作者线程
            ThreadPool.QueueUserWorkItem(new WaitCallback(RunWorkerThread));

            Console.ReadKey();
            Console.Read();
        }
    }
}
