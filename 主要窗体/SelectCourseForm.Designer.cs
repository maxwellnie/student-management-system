
namespace 学生选课系统.主要窗体
{
    partial class SelectCourseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectElem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选择该学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrdvCourse = new 学生选课系统.FUIDataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgrdvSelectedCourse = new 学生选课系统.FUIDataGridView();
            this.SelectElem1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退选全部课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SelectElem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvCourse)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvSelectedCourse)).BeginInit();
            this.SelectElem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectElem
            // 
            this.SelectElem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择该学生ToolStripMenuItem});
            this.SelectElem.Name = "SelectElem";
            this.SelectElem.Size = new System.Drawing.Size(137, 26);
            // 
            // 选择该学生ToolStripMenuItem
            // 
            this.选择该学生ToolStripMenuItem.Name = "选择该学生ToolStripMenuItem";
            this.选择该学生ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.选择该学生ToolStripMenuItem.Text = "选择该项目";
            this.选择该学生ToolStripMenuItem.Click += new System.EventHandler(this.选择该学生ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 65);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "可选课程：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(674, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 65);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "已选课程：";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgrdvCourse);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 484);
            this.panel2.TabIndex = 6;
            // 
            // dgrdvCourse
            // 
            this.dgrdvCourse.AllowUserToResizeColumns = false;
            this.dgrdvCourse.AllowUserToResizeRows = false;
            this.dgrdvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvCourse.BackgroundColor = System.Drawing.Color.White;
            this.dgrdvCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrdvCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrdvCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrdvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvCourse.ContextMenuStrip = this.SelectElem;
            this.dgrdvCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdvCourse.EnableHeadersVisualStyles = false;
            this.dgrdvCourse.GridColor = System.Drawing.Color.Blue;
            this.dgrdvCourse.Location = new System.Drawing.Point(0, 0);
            this.dgrdvCourse.Name = "dgrdvCourse";
            this.dgrdvCourse.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrdvCourse.RowHeadersVisible = false;
            this.dgrdvCourse.RowTemplate.Height = 23;
            this.dgrdvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdvCourse.Size = new System.Drawing.Size(673, 484);
            this.dgrdvCourse.TabIndex = 5;
            this.dgrdvCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdvCourse_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgrdvSelectedCourse);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(676, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 484);
            this.panel5.TabIndex = 8;
            // 
            // dgrdvSelectedCourse
            // 
            this.dgrdvSelectedCourse.AllowUserToResizeColumns = false;
            this.dgrdvSelectedCourse.AllowUserToResizeRows = false;
            this.dgrdvSelectedCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvSelectedCourse.BackgroundColor = System.Drawing.Color.White;
            this.dgrdvSelectedCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrdvSelectedCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrdvSelectedCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvSelectedCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrdvSelectedCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvSelectedCourse.ContextMenuStrip = this.SelectElem1;
            this.dgrdvSelectedCourse.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgrdvSelectedCourse.EnableHeadersVisualStyles = false;
            this.dgrdvSelectedCourse.GridColor = System.Drawing.Color.Blue;
            this.dgrdvSelectedCourse.Location = new System.Drawing.Point(0, 0);
            this.dgrdvSelectedCourse.Name = "dgrdvSelectedCourse";
            this.dgrdvSelectedCourse.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvSelectedCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrdvSelectedCourse.RowHeadersVisible = false;
            this.dgrdvSelectedCourse.RowTemplate.Height = 23;
            this.dgrdvSelectedCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdvSelectedCourse.Size = new System.Drawing.Size(494, 484);
            this.dgrdvSelectedCourse.TabIndex = 6;
            // 
            // SelectElem1
            // 
            this.SelectElem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.退选全部课程ToolStripMenuItem});
            this.SelectElem1.Name = "SelectElem";
            this.SelectElem1.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "退选课程";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 退选全部课程ToolStripMenuItem
            // 
            this.退选全部课程ToolStripMenuItem.Name = "退选全部课程ToolStripMenuItem";
            this.退选全部课程ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退选全部课程ToolStripMenuItem.Text = "退选全部课程";
            this.退选全部课程ToolStripMenuItem.Click += new System.EventHandler(this.退选全部课程ToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(673, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 484);
            this.panel4.TabIndex = 10;
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1170, 549);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCourseForm";
            this.Load += new System.EventHandler(this.SelectCourseForm_Load);
            this.SelectElem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvCourse)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvSelectedCourse)).EndInit();
            this.SelectElem1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip SelectElem;
        private System.Windows.Forms.ToolStripMenuItem 选择该学生ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FUIDataGridView dgrdvCourse;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ContextMenuStrip SelectElem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退选全部课程ToolStripMenuItem;
        private FUIDataGridView dgrdvSelectedCourse;
        private System.Windows.Forms.Panel panel4;
    }
}