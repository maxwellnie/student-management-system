using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生选课系统.操作类窗体;

namespace 学生选课系统
{
    public partial class frmStudent : Form
    {
        public frmStudent()
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
        private string selectcondition;

        public void RefreshData()
        {
            string comStr;
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            comStr = "select *  from tbl_Student";
            ds = db.GetDataFromDB(comStr);
            if (ds == null)
            {
                dgrdvStudent.DataSource =null;
            }
            else
            {
                dgrdvStudent.DataSource = ds.Tables[0];
                SetHeaderText();
            }
        }
        void SetHeaderText()
        {
            dgrdvStudent.Columns[0].HeaderText = "学号";
            dgrdvStudent.Columns[1].HeaderText = "姓名";
            dgrdvStudent.Columns[2].HeaderText = "性别";
            dgrdvStudent.Columns[3].HeaderText = "年龄";
            dgrdvStudent.Columns[4].HeaderText = "所在系";
            dgrdvStudent.Columns[5].HeaderText = "登陆密码";
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            RefreshData();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgrdvStudent_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sno.Trim() != "")
                {
                    if (MessageBox.Show("确定要删除学生吗?", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sqlStr;
                        sqlStr = "delete from tbl_Student where Sno='" + Sno+ "'";
                        DataBase db = new DataBase();
                        db.UpdateDB(sqlStr);
                        RefreshData();
                    }
                }
                else
                {
                    MessageBox.Show("没有可删除的记录！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtSelText_TextChanged(object sender, EventArgs e)
        {
            string comStr;
            DataBase db = new DataBase();
            DataSet ds = new DataSet();
            comStr = "select *  from tbl_Student where "+selectcondition.Trim()+" like '%"+txtSelText.Text.Trim()+"%'";
            ds = db.GetDataFromDB(comStr);
            if (ds != null)
            {
                dgrdvStudent.DataSource = ds.Tables[0];
                SetHeaderText();
            }
            else
            { 
                dgrdvStudent.DataSource = null;
            }
        }

        private void cmbSelcondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSelcondition.SelectedIndex)
            {
                case 0:
                    selectcondition = "Sno";
                    break;
                case 1:
                    selectcondition = "Sname";
                    break;
                case 2:
                    selectcondition = "Ssex";
                    break;
                case 3:
                    selectcondition = "Sdept";
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdataStudentForm addOrUpdataStudentForm = new AddOrUpdataStudentForm();
            addOrUpdataStudentForm.ShowDialog();
            RefreshData();
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            AddOrUpdataStudentForm addOrUpdataStudentForm = new AddOrUpdataStudentForm();
            addOrUpdataStudentForm.addn = 1;
            addOrUpdataStudentForm.addSno = Sno;
            addOrUpdataStudentForm.addSname = Sname;
            addOrUpdataStudentForm.addSdept = Sdept;
            addOrUpdataStudentForm.addSsex = Ssex;
            addOrUpdataStudentForm.addSage = Sage;
            addOrUpdataStudentForm.addSPassword = SPassword;
            addOrUpdataStudentForm.ShowDialog();
            RefreshData();

        }

        private void dgrdvStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void frmStudent_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgrdvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = this.dgrdvStudent.CurrentCell.RowIndex;
            Sno = this.dgrdvStudent[0, n].Value.ToString();
            Sname = this.dgrdvStudent[1, n].Value.ToString();
            Ssex = this.dgrdvStudent[2, n].Value.ToString();
            Sage = this.dgrdvStudent[3, n].Value.ToString();
            Sdept = this.dgrdvStudent[4, n].Value.ToString();
            SPassword = this.dgrdvStudent[5, n].Value.ToString();
        }
    }
}
