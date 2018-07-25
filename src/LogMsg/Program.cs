using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogMsg
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string str = Application.StartupPath;
            string[] sr1 = str.Split('\\');
            string sr2 = "";
            for (int i = 0; i < sr1.Length - 2; i++)
            {
                sr2 += sr1[i].ToString() + "\\";
            }
            //MessageBox.Show(sr2.ToString() + "log4net.xml");
            string sr3 = sr2 + "log4net.xml";
            log4net.Config.DOMConfigurator.Configure(new System.IO.FileInfo(sr3.ToString()));
            Application.Run(new Form1());
        }
    }
}
