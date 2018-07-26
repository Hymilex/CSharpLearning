using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    public class Tickets
    {
        static int tickets = 100;
        static object gobj = new object(); //辅助对象
        public static void SaleTicketThread1()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(gobj);
                    Thread.Sleep(1);
                    if (tickets > 0)
                    {
                        Console.WriteLine("线程1出票:{0}", tickets--);
                    }
                    else
                    {
                        break;
                    }
                }
                finally
                {
                    Monitor.Exit(gobj);
                }
            }
        }
        public static void SaleTicketThread2()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(gobj);
                    Thread.Sleep(1000);
                    if (tickets > 0)
                    {
                        Console.WriteLine("线程2出票:{0}.", tickets--);
                    }
                    else
                        break;
                }
                finally
                {
                    Monitor.Exit(gobj);
                }
            }
        }
    }
}
