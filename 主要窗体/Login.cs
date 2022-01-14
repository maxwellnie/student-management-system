using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生选课系统
{
    public partial class Login : Form
    {
        int p = 0;

        public Login()
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            panelDock.BorderStyle = BorderStyle.FixedSingle;
            panelColor.BackColor = Color.MediumSlateBlue;
           
            
             try
            {
                DataSet ds = new DataSet();
                DataSet ds1 = new DataSet();
                DataBase db = new DataBase();
                string sqlStr;
                if (purviewCheck.Checked == true)
                { 
                    sqlStr = "Select userPassword,userPurview,name from tbl_User where UserName = '" + txtUserName.Text.Trim() + "'";
                }
                else
                {
                    sqlStr = "Select SPassword from tbl_Student where Sno = '" + txtUserName.Text.Trim() + "'"; 
                }
                    ds = db.GetDataFromDB(sqlStr); 
                if (ds == null)
                {
                    errorMessageBox error = new errorMessageBox();
                    error.ShowMessage = "用户名或密码错误";
                    error.StartPosition = FormStartPosition.Manual;
                    error.Location = new Point(830, 800);
                    error.Show();
                    txtUserName.Text = "";
                    txtUserPassword.Text = "";
                    txtUserName.Focus();
                }
                else
                {
                    if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == txtUserPassword.Text.Trim())
                    {
                        panelColor.Visible = true;
                        dataSearchTimer.Start();
                        ClassShared.userInfo[0] = txtUserName.Text.Trim();
                        if (purviewCheck.Checked == true)
                            ClassShared.userInfo[1] = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        else
                            ClassShared.userInfo[1] = "学生";
                        
                        dataSearchTimer.Stop();
                        ob_FrmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        errorMessageBox error = new errorMessageBox();
                        error.ShowMessage = "用户名或密码错误";
                        error.StartPosition = FormStartPosition.Manual;
                        error.Location = new Point(830, 800);
                        error.Show();
                        
                        txtUserName.Text = "";
                        txtUserPassword.Text = "";
                        txtUserName.Focus();
                    }
 
                }
               
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "用户名或者密码错误");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        frmMain ob_FrmMain = new frmMain();
        private void dataSearchTimer_Tick(object sender, EventArgs e)
        {
            p++;
            if(panelColor.Width<=panelDock.Width)
            panelColor.Width += 10;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            windowsLeaveForMouseDown1.Form = this;
            windowsLeaveForMouseDown1.Add(panel1);
        }
    }
}
