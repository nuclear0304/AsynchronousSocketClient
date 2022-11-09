using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AsynchronousSocketClient
{
    public partial class Form1 : Form
    {
        private SocketClientHelper socketClientHelper;
        private Thread[] thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_set_Click(object sender, EventArgs e)
        {
            try
            {
                socketClientHelper = new SocketClientHelper(textBox_ServerIp.Text, Convert.ToInt32(textBox_ServerPort.Text));
                socketClientHelper.Log = WriteToTextbox;
                socketClientHelper.Exclog = WriteToExc;
            }
            catch(Exception ex)
            {
                WriteToExc(ex.ToString());
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (socketClientHelper != null)
                socketClientHelper.ConnectToServer();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (socketClientHelper != null)
                socketClientHelper.SendMsg(textBox_SendMsg.Text);
        }

        private void button_Eof_Click(object sender, EventArgs e)
        {
            if (socketClientHelper != null)
            {
                socketClientHelper.SendMsg("<EOF>");
                socketClientHelper.ConnectionClose();
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (socketClientHelper != null)
                socketClientHelper.ConnectionClose();
        }

        private void button_Looptest_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result))
            {
                var tup = new Tuple<string, int>(textBox_SendMsg.Text, result * 1);
                try
                {
                    int t_num = Convert.ToInt16(textBox_Threadnum.Text);
                    thread = new Thread[t_num];
                    for (int i = 0; i < thread.Length; i++)
                    {
                        Thread.Sleep(100);
                        thread[i] = new Thread(new ParameterizedThreadStart(ThreadTest));
                        thread[i].Start(tup);
                    }
                }
                catch (Exception ex)
                {
                    WriteToExc(ex.ToString());
                }
            }
        }

        private void button_Loopstop_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Thread t in thread)
                {
                    t.Abort();
                }
            }
            catch(Exception ex) 
            {
                WriteToExc(ex.ToString());
            }
        }

        private void WriteToTextbox(string msg)
        {
            Invoke(new Action<string>((x) => { textBox_Log.AppendText(x); }), msg);
        }

        private void WriteToExc(string msg)
        {
            Invoke(new Action<string>((x) => { textBox_Exclog.AppendText(x); }), $"{DateTime.Now.ToString("HH:mm:ss")}->{msg}{Environment.NewLine}");
        }

        private void ThreadTest(object obj)
        {
            var tup = (Tuple<string, int>)obj;

            while (true)
            {
                SocketClientHelper vs = new SocketClientHelper(textBox_ServerIp.Text, Convert.ToInt16(textBox_ServerPort.Text));
                vs.Log = WriteToTextbox;
                vs.Exclog = WriteToExc;
                vs.ConnectToServer();
                vs.SendMsg(tup.Item1);
                //vs.SendMsg($"AABBA001010203{DateTime.Now:yyyy-MM-dd HH:mm:ss}<EOF>");
                vs.ConnectionClose();
                Thread.Sleep(tup.Item2);
            }
        }
    }
}
