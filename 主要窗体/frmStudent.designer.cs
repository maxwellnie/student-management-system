namespace 学生选课系统
{
    partial class frmStudent
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSelText = new System.Windows.Forms.TextBox();
            this.btnSelAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSelcondition = new System.Windows.Forms.ComboBox();
            this.dgrdvStudent = new 学生选课系统.FUIDataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSelText);
            this.panel2.Controls.Add(this.btnSelAll);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdata);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbSelcondition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 53);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1035, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "查询值：";
            // 
            // txtSelText
            // 
            this.txtSelText.Location = new System.Drawing.Point(1038, 22);
            this.txtSelText.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelText.Name = "txtSelText";
            this.txtSelText.Size = new System.Drawing.Size(132, 26);
            this.txtSelText.TabIndex = 2;
            this.txtSelText.TextChanged += new System.EventHandler(this.txtSelText_TextChanged);
            // 
            // btnSelAll
            // 
            this.btnSelAll.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelAll.FlatAppearance.BorderSize = 0;
            this.btnSelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelAll.ForeColor = System.Drawing.Color.White;
            this.btnSelAll.Image = global::学生选课系统.Properties.Resources.查询__1_;
            this.btnSelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelAll.Location = new System.Drawing.Point(370, 0);
            this.btnSelAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(125, 53);
            this.btnSelAll.TabIndex = 9;
            this.btnSelAll.Text = "查询全部";
            this.btnSelAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelAll.UseVisualStyleBackColor = false;
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::学生选课系统.Properties.Resources.删除;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(250, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 53);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除记录";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdata
            // 
            this.btnUpdata.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdata.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdata.FlatAppearance.BorderSize = 0;
            this.btnUpdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdata.ForeColor = System.Drawing.Color.White;
            this.btnUpdata.Image = global::学生选课系统.Properties.Resources.修改;
            this.btnUpdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdata.Location = new System.Drawing.Point(125, 0);
            this.btnUpdata.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(125, 53);
            this.btnUpdata.TabIndex = 2;
            this.btnUpdata.Text = "修改记录";
            this.btnUpdata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdata.UseVisualStyleBackColor = false;
            this.btnUpdata.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::学生选课系统.Properties.Resources.添加__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加记录";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(890, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "查询内容：";
            // 
            // cmbSelcondition
            // 
            this.cmbSelcondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelcondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelcondition.FormattingEnabled = true;
            this.cmbSelcondition.Items.AddRange(new object[] {
            "学生编号",
            "学生名称",
            "性别",
            "院系"});
            this.cmbSelcondition.Location = new System.Drawing.Point(893, 22);
            this.cmbSelcondition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelcondition.Name = "cmbSelcondition";
            this.cmbSelcondition.Size = new System.Drawing.Size(131, 24);
            this.cmbSelcondition.TabIndex = 1;
            this.cmbSelcondition.SelectedIndexChanged += new System.EventHandler(this.cmbSelcondition_SelectedIndexChanged);
            // 
            // dgrdvStudent
            // 
            this.dgrdvStudent.AllowUserToResizeColumns = false;
            this.dgrdvStudent.AllowUserToResizeRows = false;
            this.dgrdvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrdvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgrdvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrdvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrdvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrdvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvStudent.EnableHeadersVisualStyles = false;
            this.dgrdvStudent.GridColor = System.Drawing.Color.Blue;
            this.dgrdvStudent.Location = new System.Drawing.Point(0, 53);
            this.dgrdvStudent.Name = "dgrdvStudent";
            this.dgrdvStudent.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrdvStudent.RowHeadersVisible = false;
            this.dgrdvStudent.RowTemplate.Height = 23;
            this.dgrdvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdvStudent.Size = new System.Drawing.Size(1170, 496);
            this.dgrdvStudent.TabIndex = 1;
            this.dgrdvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdvStudent_CellClick);
            this.dgrdvStudent.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvStudent_ColumnHeaderMouseClick);
            this.dgrdvStudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvStudent_RowHeaderMouseClick);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgrdvStudent);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.Shown += new System.EventHandler(this.frmStudent_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FUIDataGridView dgrdvStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelText;
        private System.Windows.Forms.Button btnSelAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSelcondition;
    }
}