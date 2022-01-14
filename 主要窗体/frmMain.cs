using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生选课系统.主要窗体;

namespace 学生选课系统
{
    public partial class frmMain : Form
    {
        public frmMain()
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
        frmCourse frmcourse = new frmCourse();
        frmSC frmsc = new frmSC();
        frmStudent frmstudent=new frmStudent();
        SelectCourseForm selectCourseForm = new SelectCourseForm();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            windowsLeaveForMouseDown1.Form = this;
            windowsLeaveForMouseDown1.Add(topPanel);
            if (ClassShared.userInfo[1].Trim() == "老师")
            {
                btnCoursePaenl.Visible = false;
                btnStudentPanel.Visible = false;
                btnSelectCourse.Visible = false;
            }
            else if(ClassShared.userInfo[1].Trim() == "学生")
            {
                btnSCPanel.Visible = false;
                btnCoursePaenl.Visible = false;
                btnStudentPanel.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (leftPanel.Width > 58)
            { leftPanel.Width = 58; }
            else
            {
                leftPanel.Width = 222;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void otherPanelFalse()
        {
            btnSCPanelLeft.Visible = false;
            btnCoursePanelLeft.Visible = false;
            btnStudentPanelLeft.Visible = false;
        }
        private Form addedForm = null;

        private void addForm(Form cdForm)
        {
            if (addedForm != null)
            {
                formPanel.Controls.Remove(addedForm);
            }
            addedForm = cdForm;
            cdForm.TopLevel = false; ;
            addedForm.Dock = DockStyle.Fill;
            formPanel.Controls.Add(cdForm);
            cdForm.Show();
        }
        private void btnSC_Click(object sender, EventArgs e)
        {
            frmsc.RefreshData();
            addForm(frmsc);
            btnCoursePanelLeft.Visible = false;
            btnSelectCourseLeftPanel.Visible = false;
            btnStudentPanelLeft.Visible = false;
            btnSCPanelLeft.Visible = true;
            btnSelectCourse.BackColor = Color.MidnightBlue;
            btnStudent.BackColor = Color.MidnightBlue;
            btnCourse.BackColor = Color.MidnightBlue;
            btnSC.BackColor = Color.FromArgb(25, 25, 80);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            frmcourse.RefreshData();
            addForm(frmcourse);    
            btnSCPanelLeft.Visible = false;
            btnSelectCourseLeftPanel.Visible = false;
            btnStudentPanelLeft.Visible = false;
            btnCoursePanelLeft.Visible = true;
            btnSelectCourse.BackColor = Color.MidnightBlue;
            btnStudent.BackColor = Color.MidnightBlue;
            btnSC.BackColor = Color.MidnightBlue;
            btnCourse.BackColor = Color.FromArgb(25,25,80);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmstudent.RefreshData();
            addForm(frmstudent);
            btnSCPanelLeft.Visible = false;
            btnSelectCourseLeftPanel.Visible = false;
            btnCoursePanelLeft.Visible = false;
            btnStudentPanelLeft.Visible = true;
            btnSelectCourse.BackColor = Color.MidnightBlue;
            btnCourse.BackColor = Color.MidnightBlue;
            btnSC.BackColor = Color.MidnightBlue;
            btnStudent.BackColor = Color.FromArgb(25, 25, 80);
        }

            private void btnSelectCourse_Click(object sender, EventArgs e)
        {

            addForm(selectCourseForm);
            btnSelectCourseLeftPanel.Visible = true;
            btnSCPanelLeft.Visible = false;
            btnCoursePanelLeft.Visible = false;
            btnStudentPanelLeft.Visible = false;
            btnCourse.BackColor = Color.MidnightBlue;
            btnSC.BackColor = Color.MidnightBlue;
            btnStudent.BackColor = Color.MidnightBlue;
            btnSelectCourse.BackColor = Color.FromArgb(25, 25, 80);
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
