using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生选课系统
{
    public partial class frmCourse : Form
    {
        
        public frmCourse()
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
        
        string Cno = "";string Cname = "";string Credit = "";string Semester = "";string Period = "";string name = "";string userName=""; string Cquantity = "";
        private string selectcondition;
        int n ;

        public void RefreshData()
        {
            DataSet ds1 = new DataSet();
            DataBase db1 = new DataBase();
            string str1 = "Select * From tbl_Course";
            ds1 = db1.GetDataFromDB(str1);
            if (ds1 != null)
            {
               
                dgrdvCourse.DataSource = ds1.Tables[0]; SetHeaderText();
            }
            else
                dgrdvCourse.DataSource = null;

        }
        void setdata() 
        {
            Cno = this.dgrdvCourse[0, n].Value.ToString();
            Cname = this.dgrdvCourse[1, n].Value.ToString();
            Credit = this.dgrdvCourse[2, n].Value.ToString();
            Semester = this.dgrdvCourse[3, n].Value.ToString();
            Period = this.dgrdvCourse[4, n].Value.ToString();
            name = this.dgrdvCourse[5, n].Value.ToString();
            userName = this.dgrdvCourse[6, n].Value.ToString();
            Cquantity= this.dgrdvCourse[7, n].Value.ToString();
        }
        void SetHeaderText()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            DataBase db1 = new DataBase();
            n = dgrdvCourse.CurrentCell.RowIndex;
            setdata();
            MessageV message = new MessageV();
            message.Str2 = "你确定要删除吗？";
            message.ShowDialog();
            try
            {
                if (Cno.Trim()!="")
                {
                    if (message.DialogResult==DialogResult.OK)
                    {
                        string str3 = "delete from tbl_Course where Cno='" + Cno + "'";
                        db1.UpdateDB(str3);
                        RefreshData();
                    }
                }
                else
                {
                    errorMessageBox error = new errorMessageBox();
                    error.StartPosition = FormStartPosition.Manual;
                    error.Location = new Point(830, 800);
                    error.ShowMessage = "请选择要删除的记录!";
                    error.Show();
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdataCourseForm addOrUpdataCourseForm = new AddOrUpdataCourseForm();
            addOrUpdataCourseForm.ShowDialog();
            RefreshData();
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            n = dgrdvCourse.CurrentCell.RowIndex;
            setdata();
            AddOrUpdataCourseForm addOrUpdataCourseForm = new AddOrUpdataCourseForm();
            addOrUpdataCourseForm.addCno = Cno;
            addOrUpdataCourseForm.addCname = Cname;
            addOrUpdataCourseForm.addCredit = Credit;
            addOrUpdataCourseForm.addSemester = Semester;
            addOrUpdataCourseForm.addPeriod = Period;
            addOrUpdataCourseForm.addname = name;
            addOrUpdataCourseForm.adduserName = userName;
            addOrUpdataCourseForm.addCquantity = Cquantity;
            addOrUpdataCourseForm.addn = 1;
            addOrUpdataCourseForm.ShowDialog();
            RefreshData();
        }
        private void dgrdvCourse_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && dgrdvCourse.Rows[e.RowIndex].Selected == false)
            {
                dgrdvCourse.ClearSelection();
                dgrdvCourse.Rows[e.RowIndex].Selected = true;
            }
            if (e.RowIndex != -1)
            {
                n = e.RowIndex;
                setdata();
            }
        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cmbSelcondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSelcondition.SelectedIndex)
            {
                case 0:
                    selectcondition = "Cno";
                    break;
                case 1:
                    selectcondition = "Cname";
                    break;
                case 2:
                    selectcondition = "Cteacher";
                    break;
            }
        }

        private void txtSelText_TextChanged(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            DataBase db1 = new DataBase();
            DataSet ds2 = new DataSet();
            string str2 = "Select * From tbl_Course where " + selectcondition.Trim() + " like '%" + txtSelText.Text.Trim()+"%'";
            ds2=db1.GetDataFromDB(str2);
            if (ds2!= null)
            {
                dgrdvCourse.DataSource = ds2.Tables[0];
                SetHeaderText();
            }
            else
            {
                dgrdvCourse.DataSource = null;
            }
        }

        private void dgrdvCourse_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void frmCourse_Click(object sender, EventArgs e)
        {
 
        }

        private void dgrdvCourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
