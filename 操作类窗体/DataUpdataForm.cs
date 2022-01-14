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
    public partial class DataUpdataForm : Form
    {
        public DataUpdataForm()
        {
            InitializeComponent();
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
        string Sno;
        string Cno;
        private void btnGradeIn_Click(object sender, EventArgs e)
        {
            string o=Sno + Cno;
            long f = Convert.ToInt64(o);
            string change = "insert tbl_SC values('"+f+"','" + Sno + "','" + Cno + "','" + txtGrade.Text.Trim() + "')";
            DataBase dbr = new DataBase();
            bool p = dbr.UpdateDB(change);
            if (p == true)
            {
                okMessageBoxForm ok = new okMessageBoxForm();
                ok.StartPosition = FormStartPosition.Manual;
                ok.Location = new Point(830, 800);
                ok.Show();
                Close();
            }
            else
            {
                errorMessageBox error = new errorMessageBox();
                error.StartPosition = FormStartPosition.Manual;
                error.Location = new Point(830, 800);
                error.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridViewForm viewForm = new DataGridViewForm();
            viewForm.S = 0;
            viewForm.ShowDialog();
            Sno=viewForm.ReturnElem;
            txtStudent.Text = viewForm.ReturnName;
        }

        private void selectCourse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridViewForm viewForm = new DataGridViewForm();
            viewForm.S = 1;
            viewForm.ShowDialog();
            Cno = viewForm.ReturnElem;
            txtCourse.Text = viewForm.ReturnName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataUpdataForm_Load(object sender, EventArgs e)
        {
            windowsLeaveForMouseDown1.Form = this;
            windowsLeaveForMouseDown1.Add(panel1);
        }
    }
}
