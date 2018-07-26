using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Tickets.SaleTicketThread1);
            Thread thread2 = new Thread(Tickets.SaleTicketThread2);
            thread1.Start();
            thread2.Start();
            Console.Read();
        }
    }
}
