using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using System.Threading;
namespace _4._0
{

    class Program
    {

        /*************************************************
         * 1.COM互操作
         * 2.线程
         *  a、手动开启线程
         *  b、利用线程池来开启线程
         * **/
        static void MainX(string[] args)
        {
            ThreadOperation();
            ThreadOperationI();
            
            //NewWordFile("hello world!");
        }


        //4.0后调用COM组件的方式更加优雅
        static void NewWordFile(string content)
        { 
            //启动word使之可见
            Application wordApp = new Application { Visible=true};
            wordApp.Documents.Add();
            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.ActiveDocument;
            Paragraph para = wordDoc.Paragraphs.Add();
            para.Range.Text = content;
            object fileName = @"E:\hello.doc";
            wordDoc.SaveAs2(FileName:fileName);
            wordDoc.ClosePrintPreview();
            wordApp.Quit();
            Console.WriteLine("Finished.");
        }

        static void ThreadOperation()
        {
            Thread backThread = new Thread(Worker);
            backThread.IsBackground = true;
            backThread.Start();

            backThread.Join(); //确保主线程在后台线程结束后再运行。
            Console.WriteLine("从主线程中退出.");
            Console.ReadKey();
        }
        static void Worker()
        {
            Thread.Sleep(2000);
            Console.WriteLine("从后台线程中退出.");
            //Console.ReadKey();
        }

        static void ThreadOperationI()
        {
            Thread paramThread = new Thread(new ParameterizedThreadStart(WorkerI));
            paramThread.Name = "线程1";
            paramThread.Start("123");

            Thread param1 = new Thread(new ParameterizedThreadStart(WorkerII),200);
            param1.Name = "线程2";
            param1.Start("456");
            Console.WriteLine("主线程返回.");
            Console.ReadKey();
        }
        static void WorkerI(object data)
        {
            Thread.Sleep(1000);
            Console.WriteLine("传入参数为:{0}",data.ToString());
            Console.WriteLine("从线程1返回");
            Console.ReadKey();
        }
        static void WorkerII(object data)
        {
            Thread.Sleep(1000);
            Console.WriteLine("传入参数为:{0}", data.ToString());
            Console.WriteLine("从线程2返回");
            Console.ReadKey();
        }
    }
}
