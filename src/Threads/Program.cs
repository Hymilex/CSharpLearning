using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80,42);

            MatrixBuilders ins;
            for (int i = 0; i < 26; i++)
            {
                ins = new MatrixBuilders(i*3,true);
                new Thread(ins.Move).Start();
            }

        }
    }
}
