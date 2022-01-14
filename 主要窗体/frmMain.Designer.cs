namespace 学生选课系统
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnSCPanel = new System.Windows.Forms.Panel();
            this.btnSC = new System.Windows.Forms.Button();
            this.btnSCPanelLeft = new System.Windows.Forms.Panel();
            this.btnCoursePaenl = new System.Windows.Forms.Panel();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnCoursePanelLeft = new System.Windows.Forms.Panel();
            this.btnStudentPanel = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnStudentPanelLeft = new System.Windows.Forms.Panel();
            this.btnSelectCoursePanel = new System.Windows.Forms.Panel();
            this.btnSelectCourse = new System.Windows.Forms.Button();
            this.btnSelectCourseLeftPanel = new System.Windows.Forms.Panel();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.btnMeun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.windowsLeaveForMouseDown1 = new 学生选课系统.窗体移动向量.WindowsLeaveForMouseDown(this.components);
            this.leftPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.btnSCPanel.SuspendLayout();
            this.btnCoursePaenl.SuspendLayout();
            this.btnStudentPanel.SuspendLayout();
            this.btnSelectCoursePanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnPanel);
            this.leftPanel.Controls.Add(this.iconPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(222, 696);
            this.leftPanel.TabIndex = 4;
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPanel.Controls.Add(this.btnSCPanel);
            this.btnPanel.Controls.Add(this.btnCoursePaenl);
            this.btnPanel.Controls.Add(this.btnStudentPanel);
            this.btnPanel.Controls.Add(this.btnSelectCoursePanel);
            this.btnPanel.Location = new System.Drawing.Point(0, 192);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(222, 504);
            this.btnPanel.TabIndex = 1;
            // 
            // btnSCPanel
            // 
            this.btnSCPanel.Controls.Add(this.btnSC);
            this.btnSCPanel.Controls.Add(this.btnSCPanelLeft);
            this.btnSCPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSCPanel.Location = new System.Drawing.Point(0, 171);
            this.btnSCPanel.Name = "btnSCPanel";
            this.btnSCPanel.Size = new System.Drawing.Size(222, 57);
            this.btnSCPanel.TabIndex = 3;
            // 
            // btnSC
            // 
            this.btnSC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSC.FlatAppearance.BorderSize = 0;
            this.btnSC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSC.ForeColor = System.Drawing.Color.White;
            this.btnSC.Image = global::学生选课系统.Properties.Resources._7719932;
            this.btnSC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSC.Location = new System.Drawing.Point(6, 0);
            this.btnSC.Margin = new System.Windows.Forms.Padding(4);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(216, 57);
            this.btnSC.TabIndex = 3;
            this.btnSC.Text = "成绩信息管理 >";
            this.btnSC.UseVisualStyleBackColor = false;
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnSCPanelLeft
            // 
            this.btnSCPanelLeft.BackColor = System.Drawing.Color.White;
            this.btnSCPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSCPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.btnSCPanelLeft.Name = "btnSCPanelLeft";
            this.btnSCPanelLeft.Size = new System.Drawing.Size(6, 57);
            this.btnSCPanelLeft.TabIndex = 0;
            this.btnSCPanelLeft.Visible = false;
            // 
            // btnCoursePaenl
            // 
            this.btnCoursePaenl.Controls.Add(this.btnCourse);
            this.btnCoursePaenl.Controls.Add(this.btnCoursePanelLeft);
            this.btnCoursePaenl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoursePaenl.Location = new System.Drawing.Point(0, 114);
            this.btnCoursePaenl.Name = "btnCoursePaenl";
            this.btnCoursePaenl.Size = new System.Drawing.Size(222, 57);
            this.btnCoursePaenl.TabIndex = 4;
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Image = global::学生选课系统.Properties.Resources._4641654;
            this.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourse.Location = new System.Drawing.Point(6, 0);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(216, 57);
            this.btnCourse.TabIndex = 2;
            this.btnCourse.Text = "课程信息管理 >";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnCoursePanelLeft
            // 
            this.btnCoursePanelLeft.BackColor = System.Drawing.Color.White;
            this.btnCoursePanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCoursePanelLeft.Location = new System.Drawing.Point(0, 0);
            this.btnCoursePanelLeft.Name = "btnCoursePanelLeft";
            this.btnCoursePanelLeft.Size = new System.Drawing.Size(6, 57);
            this.btnCoursePanelLeft.TabIndex = 0;
            this.btnCoursePanelLeft.Visible = false;
            // 
            // btnStudentPanel
            // 
            this.btnStudentPanel.Controls.Add(this.btnStudent);
            this.btnStudentPanel.Controls.Add(this.btnStudentPanelLeft);
            this.btnStudentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentPanel.Location = new System.Drawing.Point(0, 57);
            this.btnStudentPanel.Name = "btnStudentPanel";
            this.btnStudentPanel.Size = new System.Drawing.Size(222, 57);
            this.btnStudentPanel.TabIndex = 5;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = global::学生选课系统.Properties.Resources._690114;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(6, 0);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(216, 57);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "学生信息管理 >";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnStudentPanelLeft
            // 
            this.btnStudentPanelLeft.BackColor = System.Drawing.Color.White;
            this.btnStudentPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStudentPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.btnStudentPanelLeft.Name = "btnStudentPanelLeft";
            this.btnStudentPanelLeft.Size = new System.Drawing.Size(6, 57);
            this.btnStudentPanelLeft.TabIndex = 0;
            this.btnStudentPanelLeft.Visible = false;
            // 
            // btnSelectCoursePanel
            // 
            this.btnSelectCoursePanel.Controls.Add(this.btnSelectCourse);
            this.btnSelectCoursePanel.Controls.Add(this.btnSelectCourseLeftPanel);
            this.btnSelectCoursePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectCoursePanel.Location = new System.Drawing.Point(0, 0);
            this.btnSelectCoursePanel.Name = "btnSelectCoursePanel";
            this.btnSelectCoursePanel.Size = new System.Drawing.Size(222, 57);
            this.btnSelectCoursePanel.TabIndex = 6;
            // 
            // btnSelectCourse
            // 
            this.btnSelectCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectCourse.FlatAppearance.BorderSize = 0;
            this.btnSelectCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCourse.ForeColor = System.Drawing.Color.White;
            this.btnSelectCourse.Image = global::学生选课系统.Properties.Resources.课程;
            this.btnSelectCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectCourse.Location = new System.Drawing.Point(6, 0);
            this.btnSelectCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectCourse.Name = "btnSelectCourse";
            this.btnSelectCourse.Size = new System.Drawing.Size(216, 57);
            this.btnSelectCourse.TabIndex = 1;
            this.btnSelectCourse.Text = "选课系统     >";
            this.btnSelectCourse.UseVisualStyleBackColor = true;
            this.btnSelectCourse.Click += new System.EventHandler(this.btnSelectCourse_Click);
            // 
            // btnSelectCourseLeftPanel
            // 
            this.btnSelectCourseLeftPanel.BackColor = System.Drawing.Color.White;
            this.btnSelectCourseLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectCourseLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.btnSelectCourseLeftPanel.Name = "btnSelectCourseLeftPanel";
            this.btnSelectCourseLeftPanel.Size = new System.Drawing.Size(6, 57);
            this.btnSelectCourseLeftPanel.TabIndex = 0;
            this.btnSelectCourseLeftPanel.Visible = false;
            // 
            // iconPanel
            // 
            this.iconPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPanel.Controls.Add(this.btnMeun);
            this.iconPanel.Controls.Add(this.label1);
            this.iconPanel.Controls.Add(this.pictureBox1);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(222, 192);
            this.iconPanel.TabIndex = 0;
            // 
            // btnMeun
            // 
            this.btnMeun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeun.BackgroundImage = global::学生选课系统.Properties.Resources.菜单1;
            this.btnMeun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMeun.FlatAppearance.BorderSize = 0;
            this.btnMeun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMeun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeun.ForeColor = System.Drawing.Color.White;
            this.btnMeun.Location = new System.Drawing.Point(164, 0);
            this.btnMeun.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeun.Name = "btnMeun";
            this.btnMeun.Size = new System.Drawing.Size(58, 52);
            this.btnMeun.TabIndex = 3;
            this.btnMeun.UseVisualStyleBackColor = true;
            this.btnMeun.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "选课系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::学生选课系统.Properties.Resources.书副本;
            this.pictureBox1.Location = new System.Drawing.Point(65, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(222, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1170, 47);
            this.topPanel.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::学生选课系统.Properties.Resources._4948441;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1112, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(222, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 100);
            this.panel1.TabIndex = 6;
            // 
            // formPanel
            // 
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(222, 147);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1170, 549);
            this.formPanel.TabIndex = 7;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formPanel_Paint);
            // 
            // windowsLeaveForMouseDown1
            // 
            this.windowsLeaveForMouseDown1.Form = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 696);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩信息管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.leftPanel.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.btnSCPanel.ResumeLayout(false);
            this.btnCoursePaenl.ResumeLayout(false);
            this.btnStudentPanel.ResumeLayout(false);
            this.btnSelectCoursePanel.ResumeLayout(false);
            this.iconPanel.ResumeLayout(false);
            this.iconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button btnMeun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel btnStudentPanel;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel btnStudentPanelLeft;
        private System.Windows.Forms.Panel btnCoursePaenl;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Panel btnCoursePanelLeft;
        private System.Windows.Forms.Panel btnSCPanel;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.Panel btnSCPanelLeft;
        private System.Windows.Forms.Panel btnSelectCoursePanel;
        private System.Windows.Forms.Button btnSelectCourse;
        private System.Windows.Forms.Panel btnSelectCourseLeftPanel;
        private 窗体移动向量.WindowsLeaveForMouseDown windowsLeaveForMouseDown1;
    }
}