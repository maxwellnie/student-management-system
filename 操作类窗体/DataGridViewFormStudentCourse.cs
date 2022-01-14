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
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
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
        int n = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        string retunElem;
        string Elem;
        public int S { get { return n; }set { n = value; } }
        public string ReturnElem
        {
            get { return retunElem; }
        }
        public string ReturnName
        {
            get { return Elem; }
        }
        void SetHeaderText(int n)
        {
            if (n == 0) {
                dgrdvStudent.Columns[0].HeaderText = "学号";
                dgrdvStudent.Columns[1].HeaderText = "姓名";
                dgrdvStudent.Columns[2].HeaderText = "性别";
                dgrdvStudent.Columns[3].HeaderText = "年龄";
                dgrdvStudent.Columns[4].HeaderText = "所在系";
            }
            else
            {
                dgrdvStudent.Columns[0].HeaderText = "课程号";
                dgrdvStudent.Columns[1].HeaderText = "课程名";
                dgrdvStudent.Columns[2].HeaderText = "学期";
                dgrdvStudent.Columns[3].HeaderText = "学时";
                dgrdvStudent.Columns[4].HeaderText = "学分";
            }
        }
         void RefreshData()
        {
            string comStr0 = "select * from tbl_Student  where Sno like '%"+txtSelect.Text.Trim()+"%'";
            string comStr1 = "select * from tbl_Course  where Cno like '%" + txtSelect.Text.Trim() + "%'";
            string comStr3 = "select * from tbl_Student  where Sno like '%" + txtSelect.Text.Trim() + "%'";
            string comStr4 = "select * from tbl_Course  where userName='"+ClassShared.userInfo[0].Trim()+"' and Cno like '%" + txtSelect.Text.Trim() + "%'";
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            string comStr;
            if (n == 0) { comStr = comStr0; }else{ if (ClassShared.userInfo[1].Trim() == "老师") { comStr = comStr4; } else { comStr = comStr1; } }
            ds = db.GetDataFromDB(comStr);
            if (ds == null)
            {
                dgrdvStudent.DataSource = null;
            }
            else
            {
                
                dgrdvStudent.DataSource = ds.Tables[0];
                SetHeaderText(n);
            }
        }

        private void txtSelect_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void 选择该学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = dgrdvStudent.CurrentCell.RowIndex;
            retunElem=dgrdvStudent[0,n].Value.ToString();
            Elem = dgrdvStudent[1,n].Value.ToString();
            Close();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            windowsLeaveForMouseDown1.Form = this;
            windowsLeaveForMouseDown1.Add(panel1);
            RefreshData();
        }
    }
}
