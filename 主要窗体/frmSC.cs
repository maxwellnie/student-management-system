using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生选课系统
{

    public partial class frmSC : Form
    {
        public frmSC()
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
        string selectcondition;

        private void frmSC_Load(object sender, EventArgs e)
        {
            
            btnSelAll_Click(this,e);
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            { 
                
                if (cmbSelcondition.SelectedIndex==-1||txtSelText.Text=="")                  
                {
                    MessageBox.Show("请选择查询条件并输入查询值！");
                }
                else
                {
                    //string sqlStr = "SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno and " + selectcondition + "='" + txtSelText.Text.Trim() + "'";
                    string sqlStr =string.Format( "SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno and {0} like '%{1}%'", selectcondition,this.txtSelText.Text.Trim());
                    DataBase db = new DataBase();
                    DataSet dataSetSelect = new DataSet();
                    dataSetSelect = db.GetDataFromDB(sqlStr);

                    if (dataSetSelect==null)
                    {
                        dgrdvResult.DataSource = null;
                    }
                    else
                    {
                        dgrdvResult.DataSource = dataSetSelect.Tables[0];
                        SetHeaderText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void SetHeaderText()
        {
            dgrdvResult.Columns[0].HeaderText = "学号";
            dgrdvResult.Columns[1].HeaderText = "姓名";
            dgrdvResult.Columns[2].HeaderText = "课程号";
            dgrdvResult.Columns[3].HeaderText = "课程名";
            dgrdvResult.Columns[4].HeaderText = "成绩";
        }


        private void cmbSelcondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSelcondition.SelectedIndex)
            {
                case 0:
                    selectcondition = "tbl_SC.Sno";
                    break;
                case 1:
                    selectcondition = "tbl_SC.Cno";
                    break;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void dgrdvResult_CellMouseDown_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ( e.RowIndex != -1 && dgrdvResult.Rows[e.RowIndex].Selected == false)
            {
                dgrdvResult.ClearSelection();
                dgrdvResult.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btmFind_Click(object sender, EventArgs e)
        {
            int n = this.dgrdvResult.CurrentCell.RowIndex;
            string str = dgrdvResult[0, n].Value.ToString();
            string str1= dgrdvResult[2, n].Value.ToString();
            try
            {
                if (str.Trim() != "")
                { MessageV message = new MessageV();
                    message.Str2 = "你确定要删除吗？";
                    message.ShowDialog();
                    if (message.DialogResult==DialogResult.OK)
                    {

                        string sqlStr;
                        sqlStr = "delete from tbl_SC where Sno='" + str+ "' and Cno='"+str1+"'";
                        DataBase db = new DataBase();
                        if (db.UpdateDB(sqlStr))
                        {
                            okMessageBoxForm ok = new okMessageBoxForm();
                            ok.StartPosition = FormStartPosition.Manual;
                            ok.Location = new Point(830,800);
                            ok.Show();
                        }
                        else 
                        { 
                           errorMessageBox error =new errorMessageBox() ;
                            error.StartPosition = FormStartPosition.Manual;
                            error.Location = new Point(830,800);
                            error.Show();
                        }
                        btnSelAll_Click(this,e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdataC_Click(object sender, EventArgs e)
        {
            DataUpdataForm dataUpdataForm = new DataUpdataForm();
            dataUpdataForm.ShowDialog();
            btnSelAll_Click(this,e);
        }

        private void txtSelText_TextChanged(object sender, EventArgs e)
        {
            if (selectcondition != null)
            {
                //string sqlStr = "SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno and " + selectcondition + "='" + txtSelText.Text.Trim() + "'";
                string sqlStr;//= string.Format("SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno and {0} like '%{1}%'", selectcondition, this.txtSelText.Text.Trim());
                if (ClassShared.userInfo[1] == "老师")
                {
                    sqlStr = string.Format("SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno and " + selectcondition.Trim() + " like '%" + this.txtSelText.Text.Trim() + "%'and tbl_Course.userName='" + ClassShared.userInfo[0] + "' ");
                }
                else 
                {
                    sqlStr = string.Format("SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno and {0} like '%{1}%'", selectcondition.Trim(), this.txtSelText.Text.Trim());
                }
                DataBase db = new DataBase();
                DataSet dataSetSelect = new DataSet();
                dataSetSelect = db.GetDataFromDB(sqlStr);

                if (dataSetSelect == null)
                {
                    dgrdvResult.DataSource = null;
                }
                else
                {
                    dgrdvResult.DataSource = dataSetSelect.Tables[0];
                    //SetHeaderText();
                }
            }
           
        }
        public void RefreshData()
        {
            EventArgs e;
            e = null; 
            btnSelAll_Click(this,e);
        }
        private void btnSelAll_Click(object sender, EventArgs e)
        {
            string b;
            if (ClassShared.userInfo[1] == "老师")
            {
                b = string.Format("SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno and tbl_Course.userName='"+ClassShared.userInfo[0]+"'");
            }
            else
            {
                b = string.Format("SELECT tbl_SC.Sno,tbl_Student.Sname,tbl_SC.Cno,tbl_Course.Cname,tbl_SC.grade FROM tbl_Student,tbl_Course,tbl_SC where tbl_Course.Cno=tbl_SC.Cno and tbl_Student.Sno=tbl_SC.Sno");
            }
            DataBase dv1 = new DataBase();
            DataSet set1 = new DataSet();
            set1 = dv1.GetDataFromDB(b);
            if (set1 == null)
            {
                dgrdvResult.DataSource = null;
            }
            else
            {
                dgrdvResult.DataSource = set1.Tables[0];
                SetHeaderText();
            }
        }

        private void dgrdvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
