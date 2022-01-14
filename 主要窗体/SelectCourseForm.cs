using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生选课系统.主要窗体
{
    public partial class SelectCourseForm : Form
    {
        public SelectCourseForm()
        {
            InitializeComponent();
        }
        void SetHeaderText0()
        {
            dgrdvCourse.Columns[0].HeaderText = "课程号";
            dgrdvCourse.Columns[1].HeaderText = "课程名";
            dgrdvCourse.Columns[2].HeaderText = "学分";
            dgrdvCourse.Columns[3].HeaderText = "学期";
            dgrdvCourse.Columns[4].HeaderText = "学时";
            dgrdvCourse.Columns[5].HeaderText = "授课教师";
            dgrdvCourse.Columns[6].HeaderText = "教师账号";
            dgrdvCourse.Columns[7].HeaderText = "开放量";
            dgrdvCourse.Columns[8].HeaderText = "已使用";
           
        }
        void SetHeaderText1()
        {
            dgrdvSelectedCourse.Columns[0].HeaderText = "课程号";
            dgrdvSelectedCourse.Columns[1].HeaderText = "课程名";
            dgrdvSelectedCourse.Columns[2].HeaderText = "授课教师";
            dgrdvSelectedCourse.Columns[3].HeaderText = "学号";
        }
        public void RefreshData()
        {
            DataSet ds1 = new DataSet(); DataSet ds2 = new DataSet();
            DataBase db1 = new DataBase(); DataBase db2 = new DataBase();
            string str1 = "Select * From tbl_Course";
            string str2 = "Select Cno,Cname,Cteacher,Sno from tbl_SelectCourse where Sno='" + ClassShared.userInfo[0].Trim() + "'";
            ds1 = db1.GetDataFromDB(str1);
            ds2 = db2.GetDataFromDB(str2);
            if (ds1 != null)
            { 

            dgrdvCourse.DataSource = ds1.Tables[0];
            SetHeaderText0();
            }
            else
                dgrdvCourse.DataSource = null;
            if (ds2!= null)
            {
                dgrdvSelectedCourse.DataSource = ds2.Tables[0];
                SetHeaderText1();
            }
            else
            {
             
                dgrdvSelectedCourse.DataSource = null;
            }
            
        }

        private void 选择该学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase db1 = new DataBase();DataBase db2 = new DataBase();
            int n = dgrdvCourse.CurrentCell.RowIndex;
            string str1 = "insert into tbl_SelectCourse values('"+Convert.ToInt64(ClassShared.userInfo[0])+Convert.ToInt64(dgrdvCourse[0,n].Value.ToString())+"','"+ dgrdvCourse[0, n].Value.ToString() + "','" + dgrdvCourse[5, n].Value.ToString() + "','" + dgrdvCourse[1, n].Value.ToString()+"','"+ClassShared.userInfo[0]+"')";
            string str2 = "update tbl_Course set Cusedquantity=Cusedquantity+1 where Cno='"+dgrdvCourse[0,n].Value.ToString()+"'";
            if (db2.UpdateDB(str2) && db1.UpdateDB(str1))
            {
                okMessageBoxForm ok = new okMessageBoxForm();
                ok.StartPosition = FormStartPosition.Manual;
                ok.Location = new Point(830, 800);
                ok.Show();
            }
            else
            {
                errorMessageBox error = new errorMessageBox();
                error.StartPosition = FormStartPosition.Manual;
                error.Location = new Point(830, 800);
                error.Show();
            }
            RefreshData();
        }

        private void SelectCourseForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgrdvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBase db1 = new DataBase(); DataBase db2 = new DataBase();
            int n = dgrdvSelectedCourse.CurrentCell.RowIndex;
            string str1 = "Delete from tbl_SelectCourse where Cno='" + dgrdvSelectedCourse[0, n].Value.ToString() + "' and Sno='" + dgrdvSelectedCourse[3, n].Value.ToString() + "'";
            string str2 = "update tbl_Course set Cusedquantity=Cusedquantity-1 where Cno='" + dgrdvSelectedCourse[0, n].Value.ToString() + "'";
            if (db2.UpdateDB(str2) && db1.UpdateDB(str1))
            {
                okMessageBoxForm ok = new okMessageBoxForm();
                ok.StartPosition = FormStartPosition.Manual;
                ok.Location = new Point(830, 800);
                ok.Show();
            } else {
                errorMessageBox error = new errorMessageBox();
                error.StartPosition = FormStartPosition.Manual;
                error.Location = new Point(830, 800);
                error.Show();
            }
            RefreshData();
        }

        private void 退选全部课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase db1 = new DataBase();
            DataBase db2 = new DataBase();
            int flag = 0;
            int flag1= dgrdvSelectedCourse.Rows.Count - 1;
            for (int i = 0; i < dgrdvSelectedCourse.Rows.Count-1; i++)
            {
                string str2 = "update tbl_Course set Cusedquantity=Cusedquantity-1 where Cno='" + dgrdvSelectedCourse[0, i].Value.ToString() + "'";
                if (db2.UpdateDB(str2)) flag++;
            }
            string str1 = "Delete from tbl_SelectCourse where Sno='"+ClassShared.userInfo[0]+"'";
            if (db1.UpdateDB(str1) && flag == flag1)
            {
                okMessageBoxForm ok = new okMessageBoxForm();
                ok.StartPosition = FormStartPosition.Manual;
                ok.Location = new Point(830, 800);
                ok.Show();
            } else {
                errorMessageBox error = new errorMessageBox();
                error.StartPosition = FormStartPosition.Manual;
                error.Location = new Point(830, 800);
                error.Show();
            }
            RefreshData();
        }
    }
}
