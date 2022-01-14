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
    public partial class DataGridViewFormTeacher : Form
    {
        public DataGridViewFormTeacher()
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
        string returnElem0,returnElem1;
        public string ReturnElem0
        {
            get { return returnElem0; }
        }
        public string ReturnElem1
        {
            get { return returnElem1; }
        }
        void SetHeaderText()
        {
            dgrdvTeacher.Columns[0].HeaderText = "账号名称";
            dgrdvTeacher.Columns[1].HeaderText = "教师名称";
        }
        void refreshdata()
        {
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            string comStr = "select userName,name from tbl_user where userPurview='老师' and userName like '%" + txtSelect.Text.Trim() + "%'";
            ds = db.GetDataFromDB(comStr);
            if (ds == null)
            {
                dgrdvTeacher.DataSource = null;
            }
            else
            {

                dgrdvTeacher.DataSource = ds.Tables[0];
                SetHeaderText();
            }
        }
        private void txtSelect_TextChanged(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewFormTeacher_Load(object sender, EventArgs e)
        {
            refreshdata();
            windowsLeaveForMouseDown1.Form = this;
            windowsLeaveForMouseDown1.Add(panel1);
        }

        private void 选择该学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = dgrdvTeacher.CurrentCell.RowIndex;
            returnElem0 = dgrdvTeacher[0, n].Value.ToString();
            returnElem1 = dgrdvTeacher[1, n].Value.ToString();
            Close();
        }
    }
}
