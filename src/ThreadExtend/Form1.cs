using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadExtend
{
    public partial class Form1 : Form
    {
        //定义委托
        private delegate void setTextValueCallBack(int value);
        //声明回调
        private setTextValueCallBack setCallBack;



        public void setValue(int val)
        {
            this.textBox1.Text = val.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            setCallBack = new setTextValueCallBack(setValue);
            Thread thread = new Thread(new ThreadStart(Test));
            thread.IsBackground = true;
            thread.Start();
        }

        public  void Test()
        {
            for (int i = 0; i < 1000; i++)
            {
                //this.textBox1.Text = i.ToString();
                
                this.Invoke(new Action(() => {
                    setValue(i);
                }));
                Thread.Sleep(1000); 
                //this.Invoke(setCallBack,i);
            }
        }

        /// <summary>
        /// 解决方案一 屏蔽c#对跨线程的检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的访问
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void async_Click(object sender, EventArgs e)
        {
            string str = "***************btnAsync_Click Start:"+Thread.CurrentThread.ManagedThreadId.ToString()+"\n";
            Action<string> action = this.DoSomethingLong;
            //传送参数
            action.Invoke("hello world");
            
            action.BeginInvoke("你好啊", null, null);
            str = str + "***************btnAsync_Click End " + Thread.CurrentThread.ManagedThreadId.ToString();
            //richTextBox1.Text
            this.Invoke(new Action(() => {
                setRichText(str);
            }));

            //定义回调函数
            IAsyncResult asyncResult = null;
            AsyncCallback callback = p => {
                this.Invoke(new Action(() => {
                    richTextBox1.Text += "到这里计算已经完成了。" + Thread.CurrentThread.ManagedThreadId.ToString("00").ToString() + "\n";
                }));
            };
            asyncResult = action.BeginInvoke("有回调函数",callback,null);

            Func<string> func = () => {
                Thread.Sleep(3000);
                return "这个是不用delegate声明的委托!";
            };

            IAsyncResult asyncRst = func.BeginInvoke(p => {
                Console.WriteLine(p.AsyncState);
                this.Invoke(new Action(() => {
                    richTextBox1.Text += p.AsyncState.ToString();
                }));
            },"异步返回值");

            this.Invoke(new Action(() => {
                func.EndInvoke(asyncRst);
            }));


        }


        public void DoSomethingLong(string name)
        {
            string str = "****************DoSomethingLong {" + name + "} Start " + Thread.CurrentThread.ManagedThreadId.ToString("00") + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "***************\n";
            long lResult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lResult += i;
            }
            str =str+ "****************DoSomethingLong {" + name + "}  End  " + Thread.CurrentThread.ManagedThreadId.ToString("00") + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "***************\n";
            this.Invoke(new Action(() =>
            {
                this.setRichText(str);
            }));
        }
        void setRichText(string val)
        {
            this.richTextBox1.Text += val;
        }
    }
}
