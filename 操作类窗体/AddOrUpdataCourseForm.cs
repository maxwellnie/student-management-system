using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生选课系统.操作类窗体;

namespace 学生选课系统
{
    public partial class AddOrUpdataCourseForm : Form
    {
        public AddOrUpdataCourseForm()
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
        DataSet ds1 = new DataSet();
        DataBase db1 = new DataBase();
        string userName;
        string name;
        string Cno = ""; string Cname = ""; string Credit = ""; string Semester = ""; string Period = "";string Cquantity = "";
        int n = 0; string str2;
        public string addCno
        {
            set { Cno = value; }
        }
        public string addCname
        {
            set { Cname = value; }
        }
        public string addCredit
        {
            set { Credit = value; }
        }
        public string addSemester
        {
            set { Semester = value; }
        }
        public string addPeriod
        {
            set { Period = value; }
        }
        public string addname
        {
            set { name = value; }
        }
        public string adduserName
        {
            set { userName = value; }
        }
        public string addCquantity
        {
            set { Cquantity = value; }
        }
        public int addn
        {
            set { n = value; }
        }
        void Clear()
        {
            txtNo.Text = "";
            txtName.Text = "";
            txtCredit.Text = "";
            cmbSemester.SelectedIndex = -1;
            txtPeriod.Text = "";
            txtTeacher.Text= "";
            txtCquantity.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddOrUpdataCourseForm_Load(object sender, EventArgs e)
        {
            if (n == 1)
            {
                btnAdd.Visible = false; txtNo.Enabled = false; btnUpdate.Visible = true;
                txtNo.Text = Cno;
                txtName.Text = Cname;
                txtCredit.Text = Credit;
                cmbSemester.Text = Semester;
                txtPeriod.Text = Period;
                txtTeacher.Text = userName + "-" + name;
                txtCquantity.Text = Cquantity;
            }
            windowsLeaveForMouseDown1.Form = this;
            windowsLeaveForMouseDown1.Add(panel2);
        }

        private void OpenViewList_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridViewFormTeacher dataGridViewFormTeacher = new DataGridViewFormTeacher();
            dataGridViewFormTeacher.ShowDialog();
            userName = dataGridViewFormTeacher.ReturnElem0;
            name = dataGridViewFormTeacher.ReturnElem1;
            txtTeacher.Text = userName + "-" + name;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataBase db = new DataBase();
                string str4 = "Update tbl_Course set Cname='" + txtName.Text.Trim() + "',Ccredit='" + txtCredit.Text.Trim() + "',Csemester='" + cmbSemester.Text.Trim() + "',Cperiod='" + txtPeriod.Text.Trim() + "', Cno='" + txtNo.Text.Trim() + "',Cteacher='" + name + "',userName='" + userName + "',Cquantity='"+txtCquantity.Text.Trim()+"',Cusedquantity=0 where Cno='" + Cno + "'";
                bool p= db.UpdateDB(str4);
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
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataBase db2 = new DataBase();
            try
            {
                if (txtNo.Text.Trim() != "" && txtName.Text.Trim() != "")
                {
                    str2 = "insert into tbl_Course values('" + txtNo.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtCredit.Text.Trim() + "','" + cmbSemester.Text.Trim() + "','" + txtPeriod.Text.Trim() + "','" + name + "','" + userName + "','"+txtCquantity.Text.Trim()+"',0)";
                    bool b = db2.UpdateDB(str2); 
                    if (b == true)
                    {
                        MessageV message = new MessageV();
                        message.Str2 = "添加成功，还要继续添加吗？";
                        message.ShowDialog();
                        if (message.DialogResult == DialogResult.OK)
                        {
                            Clear();

                        }
                        else Close();
                    }
                    else
                    {
                        errorMessageBox error = new errorMessageBox();
                        error.StartPosition = FormStartPosition.Manual;
                        error.Location = new Point(830, 800);
                        error.ShowMessage = "错误：重复的项目！";
                        error.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("输入的课程号课程名不能为空");
                    txtNo.Focus();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }
    }
}
