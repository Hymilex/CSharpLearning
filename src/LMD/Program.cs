using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMD
{
    class Program
    {
        static void Main(string[] args)
        {
            LMDF();
        }

        public static void LMDF()
        {
            Button btn1 = new Button();
            btn1.Click += (sender,e) => {
                ReportEvent("Click事件",sender,e);
            };
            btn1.KeyPress+=delegate(object sender,KeyPressEventArgs e){
                ReportEvent("KeyPress事件",sender,e);
            };
            btn1.Text = "点击我";
            Form frm = new Form();
            frm.Text = "控制台的窗体";
            frm.AutoSize = true;
            frm.Controls.Add(btn1);
            Application.Run(frm);
        }

        private static void ReportEvent(string title,object sender,EventArgs e)
        {
            Console.WriteLine("发生事件:{0}",title);
            Console.WriteLine("发生事件对象:{0}",sender);
            Console.WriteLine("发生事件参数：{0}",e.GetType());
            Console.WriteLine();
        }

    }
}
