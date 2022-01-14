using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生选课系统
{
    public partial class okMessageBoxForm : Form
    {
        public okMessageBoxForm()
        {
            InitializeComponent();
        }
        string message="成功！";
        public string ShowMessage
        {
            get { return message; }
            set { message = value; }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okMessageBoxForm_Load(object sender, EventArgs e)
        {
            txtMessage.Text = message;
        }
    }
}
