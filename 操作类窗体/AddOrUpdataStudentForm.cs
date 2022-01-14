using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生选课系统.操作类窗体
{
    public partial class AddOrUpdataStudentForm : Form
    {
        public AddOrUpdataStudentForm()
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
        string Sno = ""; string Sname = ""; string Ssex = ""; string Sage = ""; string Sdept = ""; string SPassword = "";
            int n = 0;

        public string addSno
        {
            set { Sno = value; }
        }
        public string addSname
        {
            set { Sname = value; }
        }
        public string addSsex
        {
            set { Ssex = value; }
        }
        public string addSage
        {
            set { Sage = value; }
        }
        public string addSdept
        {
            set { Sdept = value; }
        }
        public string addSPassword
        {
            set { SPassword = value; }
        }
        public int addn
        {
            set { n = value; }
        }
        void Clear()
        {
            txtNo.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            cmbSex.SelectedIndex = -1;
            txtDept.Text = "";
            txtPassword0.Text = "";
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                    btnAdd.Text = "添加";
                    if (txtNo.Text.Trim() != "" && txtName.Text.Trim() != "")
                    {
                        string sqlStr;
                        sqlStr = "insert into tbl_Student values ('" + txtNo.Text.Trim() + "','" + txtName.Text.Trim() + "','" + cmbSex.Text.Trim() + "','" + txtAge.Text.Trim() + "','" + txtDept.Text.Trim() + "','"+txtPassword0.Text.Trim()+"')";
                        DataBase db = new DataBase();
                        bool b;
                        b = db.UpdateDB(sqlStr);

                    if (b == true)
                    {
                        MessageV message = new MessageV();
                        message.Str2 = "添加成功，还要继续添加吗？";
                        message.ShowDialog();
                        if (message.DialogResult == DialogResult.OK)
                        {
                            Clear();
                        }
                        else
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("学号与姓名不能为空！");
                        txtNo.Focus();
                        btnAdd.Text = "确定";
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                    string sqlStr;
                    sqlStr = "Update tbl_Student set Sname='" + txtName.Text.Trim() + "',Ssex='" + cmbSex.Text.Trim() + "',Sage='" + txtAge.Text.Trim() + "',Sdept='" + txtDept.Text.Trim() + "',Spassword='"+txtPassword0.Text.Trim()+"' where Sno='" + txtNo.Text.Trim() + "'";
                    DataBase db = new DataBase();
                if (db.UpdateDB(sqlStr))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddOrUpdataStudentForm_Load(object sender, EventArgs e)
        {
            if (n == 1) { btnAdd.Visible = false;txtNo.Enabled = false;btnUpdate.Visible = true;
                txtNo.Text = Sno;
                txtName.Text =Sname;
                txtAge.Text =Sage;
                cmbSex.Text =Ssex;
                txtDept.Text =Sdept;
                txtPassword0.Text =SPassword;
            }
            windowsLeaveForMouseDown1.Form = this;
            windowsLeaveForMouseDown1.Add(panel2);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
