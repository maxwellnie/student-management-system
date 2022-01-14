
namespace 学生选课系统
{
    partial class DataUpdataForm
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
            this.btnGradeIn = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCourse = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.Label();
            this.selectCourse = new System.Windows.Forms.LinkLabel();
            this.selectStudent = new System.Windows.Forms.LinkLabel();
            this.windowsLeaveForMouseDown1 = new 学生选课系统.窗体移动向量.WindowsLeaveForMouseDown(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGradeIn
            // 
            this.btnGradeIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGradeIn.FlatAppearance.BorderSize = 0;
            this.btnGradeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradeIn.ForeColor = System.Drawing.Color.White;
            this.btnGradeIn.Location = new System.Drawing.Point(127, 242);
            this.btnGradeIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradeIn.Name = "btnGradeIn";
            this.btnGradeIn.Size = new System.Drawing.Size(103, 36);
            this.btnGradeIn.TabIndex = 4;
            this.btnGradeIn.Text = "成绩录入";
            this.btnGradeIn.UseVisualStyleBackColor = false;
            this.btnGradeIn.Click += new System.EventHandler(this.btnGradeIn_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("黑体", 12F);
            this.txtGrade.Location = new System.Drawing.Point(106, 157);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(159, 26);
            this.txtGrade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F);
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "成绩：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F);
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "请选择课程：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F);
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择学生：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 40);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("黑体", 20F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(306, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCourse);
            this.panel2.Controls.Add(this.txtStudent);
            this.panel2.Controls.Add(this.selectCourse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnGradeIn);
            this.panel2.Controls.Add(this.selectStudent);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtGrade);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 303);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCourse
            // 
            this.txtCourse.AutoSize = true;
            this.txtCourse.Font = new System.Drawing.Font("黑体", 12F);
            this.txtCourse.Location = new System.Drawing.Point(155, 100);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(0, 16);
            this.txtCourse.TabIndex = 7;
            // 
            // txtStudent
            // 
            this.txtStudent.AutoSize = true;
            this.txtStudent.Font = new System.Drawing.Font("黑体", 12F);
            this.txtStudent.Location = new System.Drawing.Point(155, 56);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(0, 16);
            this.txtStudent.TabIndex = 6;
            // 
            // selectCourse
            // 
            this.selectCourse.AutoSize = true;
            this.selectCourse.Font = new System.Drawing.Font("黑体", 12F);
            this.selectCourse.Location = new System.Drawing.Point(262, 100);
            this.selectCourse.Name = "selectCourse";
            this.selectCourse.Size = new System.Drawing.Size(40, 16);
            this.selectCourse.TabIndex = 5;
            this.selectCourse.TabStop = true;
            this.selectCourse.Text = "选择";
            this.selectCourse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectCourse_LinkClicked);
            // 
            // selectStudent
            // 
            this.selectStudent.AutoSize = true;
            this.selectStudent.Font = new System.Drawing.Font("黑体", 12F);
            this.selectStudent.Location = new System.Drawing.Point(262, 56);
            this.selectStudent.Name = "selectStudent";
            this.selectStudent.Size = new System.Drawing.Size(40, 16);
            this.selectStudent.TabIndex = 4;
            this.selectStudent.TabStop = true;
            this.selectStudent.Text = "选择";
            this.selectStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectStudent_LinkClicked);
            // 
            // windowsLeaveForMouseDown1
            // 
            this.windowsLeaveForMouseDown1.Form = null;
            // 
            // DataUpdataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataUpdataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DataUpdataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGradeIn;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel selectCourse;
        private System.Windows.Forms.LinkLabel selectStudent;
        private System.Windows.Forms.Label txtCourse;
        private System.Windows.Forms.Label txtStudent;
        private 窗体移动向量.WindowsLeaveForMouseDown windowsLeaveForMouseDown1;
    }
}