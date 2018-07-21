using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4._0
{
    class ThreadClass
    {

        static void Main()
        {
            Console.WriteLine("主线程ID:{0}", Thread.CurrentThread.ManagedThreadId);
            //ThreadPool.SetMaxThreads(1000,1000);
            //ThreadPool.QueueUserWorkItem(new WaitCallback(RunWorkerThread));
            ThreadPool.QueueUserWorkItem(CallBackItem);
            ThreadPool.QueueUserWorkItem(CallBackItem, "work");
            Thread.Sleep(3000);
            Console.WriteLine("主线程退出!");
        }
        static void CallBackItem(object state)
        {
            Console.WriteLine("线程池线程开始进行。");
            if (state != null)
            {
                Console.WriteLine("线程池ID:{0},传入参数:{1}", Thread.CurrentThread.ManagedThreadId, state.ToString());
            }
            else
            {
                Console.WriteLine("线程池ID:{0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
