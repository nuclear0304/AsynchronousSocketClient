namespace AsynchronousSocketClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Eof = new System.Windows.Forms.Button();
            this.textBox_ServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ServerIp = new System.Windows.Forms.TextBox();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBox_SendMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Threadnum = new System.Windows.Forms.TextBox();
            this.label_Threadnum = new System.Windows.Forms.Label();
            this.button_Loopstop = new System.Windows.Forms.Button();
            this.button_Looptest = new System.Windows.Forms.Button();
            this.textBox_Exclog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_set = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Eof
            // 
            this.button_Eof.Location = new System.Drawing.Point(30, 75);
            this.button_Eof.Name = "button_Eof";
            this.button_Eof.Size = new System.Drawing.Size(75, 23);
            this.button_Eof.TabIndex = 17;
            this.button_Eof.Text = "send end";
            this.button_Eof.UseVisualStyleBackColor = true;
            this.button_Eof.Click += new System.EventHandler(this.button_Eof_Click);
            // 
            // textBox_ServerPort
            // 
            this.textBox_ServerPort.Location = new System.Drawing.Point(195, 12);
            this.textBox_ServerPort.Name = "textBox_ServerPort";
            this.textBox_ServerPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_ServerPort.TabIndex = 16;
            this.textBox_ServerPort.Text = "5001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "server";
            // 
            // textBox_ServerIp
            // 
            this.textBox_ServerIp.Location = new System.Drawing.Point(49, 12);
            this.textBox_ServerIp.Name = "textBox_ServerIp";
            this.textBox_ServerIp.Size = new System.Drawing.Size(100, 22);
            this.textBox_ServerIp.TabIndex = 13;
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(11, 89);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.Size = new System.Drawing.Size(283, 241);
            this.textBox_Log.TabIndex = 12;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(30, 47);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 11;
            this.button_Send.Text = "send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(30, 18);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 10;
            this.button_Connect.Text = "connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // textBox_SendMsg
            // 
            this.textBox_SendMsg.Location = new System.Drawing.Point(49, 40);
            this.textBox_SendMsg.Name = "textBox_SendMsg";
            this.textBox_SendMsg.Size = new System.Drawing.Size(246, 22);
            this.textBox_SendMsg.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "msg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "recv";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Controls.Add(this.button_Eof);
            this.groupBox1.Location = new System.Drawing.Point(306, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 137);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single acton";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(30, 104);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 18;
            this.button_Close.Text = "force close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Threadnum);
            this.groupBox2.Controls.Add(this.label_Threadnum);
            this.groupBox2.Controls.Add(this.button_Loopstop);
            this.groupBox2.Controls.Add(this.button_Looptest);
            this.groupBox2.Location = new System.Drawing.Point(306, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 148);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Looping test";
            // 
            // textBox_Threadnum
            // 
            this.textBox_Threadnum.Location = new System.Drawing.Point(83, 21);
            this.textBox_Threadnum.MaxLength = 2;
            this.textBox_Threadnum.Name = "textBox_Threadnum";
            this.textBox_Threadnum.Size = new System.Drawing.Size(36, 22);
            this.textBox_Threadnum.TabIndex = 22;
            this.textBox_Threadnum.Text = "1";
            this.textBox_Threadnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Threadnum
            // 
            this.label_Threadnum.AutoSize = true;
            this.label_Threadnum.Location = new System.Drawing.Point(19, 26);
            this.label_Threadnum.Name = "label_Threadnum";
            this.label_Threadnum.Size = new System.Drawing.Size(58, 12);
            this.label_Threadnum.TabIndex = 21;
            this.label_Threadnum.Text = "thread num";
            // 
            // button_Loopstop
            // 
            this.button_Loopstop.Location = new System.Drawing.Point(30, 114);
            this.button_Loopstop.Name = "button_Loopstop";
            this.button_Loopstop.Size = new System.Drawing.Size(75, 23);
            this.button_Loopstop.TabIndex = 11;
            this.button_Loopstop.Text = "Stop";
            this.button_Loopstop.UseVisualStyleBackColor = true;
            this.button_Loopstop.Click += new System.EventHandler(this.button_Loopstop_Click);
            // 
            // button_Looptest
            // 
            this.button_Looptest.Location = new System.Drawing.Point(30, 84);
            this.button_Looptest.Name = "button_Looptest";
            this.button_Looptest.Size = new System.Drawing.Size(75, 23);
            this.button_Looptest.TabIndex = 10;
            this.button_Looptest.Text = "Start";
            this.button_Looptest.UseVisualStyleBackColor = true;
            this.button_Looptest.Click += new System.EventHandler(this.button_Looptest_Click);
            // 
            // textBox_Exclog
            // 
            this.textBox_Exclog.Location = new System.Drawing.Point(453, 32);
            this.textBox_Exclog.Multiline = true;
            this.textBox_Exclog.Name = "textBox_Exclog";
            this.textBox_Exclog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Exclog.Size = new System.Drawing.Size(194, 298);
            this.textBox_Exclog.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "exc log";
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(336, 12);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(75, 23);
            this.button_set.TabIndex = 25;
            this.button_set.Text = "set server";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 52);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "60";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "time tick";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 345);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Exclog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SendMsg);
            this.Controls.Add(this.textBox_ServerPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ServerIp);
            this.Controls.Add(this.textBox_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "非同步Socket Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Eof;
        private System.Windows.Forms.TextBox textBox_ServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ServerIp;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox textBox_SendMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Looptest;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_Exclog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Loopstop;
        private System.Windows.Forms.TextBox textBox_Threadnum;
        private System.Windows.Forms.Label label_Threadnum;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

