using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary2
{
    public partial class MessageV : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        string str1 = "提示";
        string str2 = "你确定吗？";
        string str3 = "确定";
        string str4 = "取消";
        Image image=null;
        public MessageV()
        {
            InitializeComponent();
        }
        public string Str1 
        {
            get { return str1; }
            set { str1 = value; }
        }
        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        public string Str3
        {
            get { return str3; }
            set { str3 = value; }
        }
        public string Str4
        {
            get { return str4; }
            set { str4 = value; }
        }
        public Image Iconimage
        {
            get { return image; }
            set { image = value; }
        }

        private void MessageV_Load(object sender, EventArgs e)
        {
            labelTitle.Text = str1;
            labelMessage.Text = str2;
            btnOK.Text = str3;
            btnCancel.Text = str4;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
