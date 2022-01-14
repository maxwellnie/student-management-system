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
    public partial class errorMessageBox : Form
    {
        public errorMessageBox()
        {
            InitializeComponent();
        }
        string message="失败！";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void errorMessageBox_Load(object sender, EventArgs e)
        {
            errorMessage.Text = message;
        }
    }
}
