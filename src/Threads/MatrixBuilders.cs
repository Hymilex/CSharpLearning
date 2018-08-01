using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class MatrixBuilders
    {
        static object locker = new object();

        Random rand;

        const string letters = "QWERTYUIOPLKJHGFDSAZXCVBNM1234567890";

        public int Column { get; set; }
        public bool NeedSeconds { get; set; }
        public MatrixBuilders(int col, bool needSecond)
        {
            Column = col;
            rand = new Random((int)DateTime.Now.Ticks);
            NeedSeconds = needSecond;
        }

        private char GetChar()
        { 
            return letters.ToCharArray()[rand.Next(0,35)];
        }

        public void Move()
        {
            int lenght;
            int count;
            while (true)
            {
                count = rand.Next(3,12);
                lenght = 0;
                Thread.Sleep(rand.Next(20,5000));

                for (int i = 0; i < 40; i++)
                {
                    lock (locker)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.CursorTop = i - lenght;
                        for (int j = i - lenght - 1; j < i; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine("||");
                        }
                        if (lenght < count)
                        {
                            lenght++;
                        }
                        else
                        {
                            if (lenght == count)
                            {
                                count = 0;
                            }
                        }
                        if (NeedSeconds && i < 20 && i > lenght + 2 && (rand.Next(1, 5) == 3))
                        {
                            new Thread(new MatrixBuilders(Column,false).Move).Start();
                            NeedSeconds = false;
                        }

                        if (39 - i < lenght)
                        {
                            lenght--;
                        }
                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        Thread.Sleep(10);

                    }
                }
            }
        }

    }
}
